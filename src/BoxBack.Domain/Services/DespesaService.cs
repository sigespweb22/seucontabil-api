using System.Diagnostics;
using AutoMapper;
using Microsoft.Extensions.Logging;
using BoxBack.Domain.Interfaces;
using System.Threading.Tasks;
using BoxBack.Domain.InterfacesRepository;
using BoxBack.Domain.Models;
using BoxBack.Domain.ServicesValidators;
using FluentValidation;
using System;
using BoxBack.Domain.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BoxBack.Domain.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly ILogger _logger;
        private readonly IDespesaRepository _despesaRepository;
        private readonly IDespesaParcelaService _despesaParcelaService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public DespesaService(ILogger<ClienteService> logger,
                              IDespesaRepository despesaRepository,
                              IDespesaParcelaService despesaParcelaService,
                              IMapper mapper,
                              IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _despesaRepository = despesaRepository;
            _despesaParcelaService = despesaParcelaService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(Despesa despesa)
        {
            #region Entity validations
            if (despesa.SistemaParcelamento.Equals(SistemaParcelamentoEnum.TABELA_PRICE))
            {
                var despesaToParcelamentoValidator = new DespesaToParcelamentoValidator();
                despesaToParcelamentoValidator.ValidateAndThrow(despesa);
            } else 
            {
                var despesaValidator = new DespesaValidator();
                despesaValidator.ValidateAndThrow(despesa);
            }
            #endregion

            #region Create despesa
            try
            {
                await _despesaRepository.AddAsync(despesa);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
            }
            #endregion

            #region Create parcelas
            try
            {
                // await _despesaParcelaService.AddRangeWhithoutCommitAsync(await GerarParcelas(despesa));
                await GerarParcelas(despesa);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma parcela da despesa: {ex.Message}", ex);
            }
            #endregion

            #region Commit
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
            }
            #endregion
        }

        private async Task<IEnumerable<DespesaParcela>> GerarParcelas(Despesa despesa)
        {
            var parcelas = new List<DespesaParcela>();
            var valorFinanciado = Math.Round((despesa.ValorPrincipal - despesa.ValorEntrada) + despesa.Iof + despesa.Seguro + despesa.Tarifa, 2);

            for (var i=0; i < despesa.TotalParcelas; i++)
            {
                var vencimentoParcelaAtual =  i.Equals(0) ? despesa.DataVencimentoPrimeiraParcela : CalcularDataVencimentoParcela(despesa.DataVencimentoPrimeiraParcela.Day, parcelas[i - 1].DataVencimento);
                var diasEntreParcelas = CalcularDiasEntreParcelas(vencimentoParcelaAtual, i.Equals(0) ? despesa.DataOperacao : parcelas[i - 1].DataVencimento);
                var saldoInicial = i.Equals(0) ? valorFinanciado : parcelas[i - 1].SaldoFinal;
                var jurosParcela = CalcularJurosParcela(despesa.CustoEfetivoTotalDia, diasEntreParcelas, saldoInicial);

                var despesaParcela = new DespesaParcela()
                {
                    Id = Guid.NewGuid(),
                    DataVencimento = vencimentoParcelaAtual,
                    ParcelaNumero = i,
                    DiasEntreParcelas = diasEntreParcelas,
                    SaldoInicial = saldoInicial,
                    Juros = jurosParcela,
                    DespesaId = despesa.Id
                };
                parcelas.Add(despesaParcela);
            }

            var valorParcela = CalcularValorParcela(valorFinanciado, parcelas.Sum(x => x.Juros), despesa.TotalParcelas);
            
            // Atribuindo valor de Parcela
            parcelas.Select(p => { p.ValorParcela = valorParcela; return p; }).ToList();

            // Atribuindo valor de Saldo Final
            parcelas.Select(p => { 
                p.SaldoFinal = CalcularSaldoFinal(p.SaldoInicial, p.Juros, parcelas.FirstOrDefault().ValorParcela);
                return p;
            }).ToList();

            // Atribuindo valor de Saldo Final
            parcelas.Select(p => { 
                p.Amortizacao = CalcularAmortizacao(p.Juros, parcelas.FirstOrDefault().ValorParcela);
                return p;
            }).ToList();

            for (var i = 0; i < parcelas.Count(); i++)
            {
                try
                {
                    await _despesaParcelaService.AddWhithoutCommitAsync(parcelas[i]);
                    await _unitOfWork.CommitAsync();    
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(ex.Message);
                    throw new Exception($"Erro ao tentar adicionar uma despesa: {ex.Message}", ex);
                }
            }

            return parcelas;
        }
        private DateTimeOffset CalcularDataVencimentoParcela (int diaFixo, DateTimeOffset vencimentoAnterior)
        {
            // Adiciona o número de meses desejado
            var novaData = vencimentoAnterior.AddMonths(1);

            // Verifica se a data resultante é válida
            if (novaData.Year != vencimentoAnterior.Year || novaData.Month != (vencimentoAnterior.Month + 1) % 12)
            {
                // Ajusta para o último dia do mês anterior
                novaData = new DateTimeOffset(novaData.Year, novaData.Month, 1, 0, 0, 0, vencimentoAnterior.Offset).AddMonths(1).AddDays(-1);
            }
            
            var novoVencimento = new DateTimeOffset(novaData.Year, novaData.Month, diaFixo, 0, 0, 0, new TimeSpan(-3, 0, 0));

            // ** Validate
            string nomeDoDiaDaSemana = novoVencimento.ToString("dddd", new CultureInfo("pt-BR"));
            switch(nomeDoDiaDaSemana)
            {
                case "sábado":
                    return novoVencimento.AddDays(2);
                case "domingo":
                    return novoVencimento.AddDays(1);
                default:
                    return novoVencimento;
            }
        }
        private int CalcularDiasEntreParcelas (DateTimeOffset vencimentoParcelaAtual, DateTimeOffset vencimentoParcelaAnterior)
        {
            TimeSpan totalDias = vencimentoParcelaAtual - vencimentoParcelaAnterior;
            return Convert.ToInt32(totalDias.TotalDays);
        }
        private decimal CalcularJurosParcela (decimal custoEfetivoDia, int totalDias, decimal valorMonetario)
        {
            double taxaDiaria = (double)(1 + custoEfetivoDia / 100);
            double resultado = Math.Pow(taxaDiaria, totalDias) - 1;
            resultado *= (double)valorMonetario;

            return Math.Round((decimal)resultado, 2);
        }
        private decimal CalcularValorParcela (decimal valorFinanciado, decimal valorJuros, Int64 totalParcelas)
        {
            return Math.Round((valorFinanciado + valorJuros) / totalParcelas, 2);
        }
        private decimal CalcularSaldoFinal (decimal saldoInicial, decimal juros, decimal valorParcela)
        {
            return Math.Round((saldoInicial + juros) - valorParcela, 2);
        }
        private decimal CalcularAmortizacao (decimal juros, decimal valorParcela)
        {
            return Math.Round(juros - valorParcela, 2);
        }

        public void Dispose()
        {
            _despesaRepository.Dispose();
        }
    }
}