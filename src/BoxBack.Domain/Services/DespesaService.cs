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

            #region Persistance
            try
            {
                await _despesaRepository.AddAsync(despesa);
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
                await _despesaParcelaService.AddRangeWhithoutCommitAsync(await GerarParcelas(despesa));
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
                return await _unitOfWork.CommitAsync();
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
            var valorFinanciado = (despesa.ValorPrincipal - despesa.ValorEntrada) + despesa.Iof + despesa.Seguro + despesa.Tarifa;

            for (var i=1; i < despesa.TotalParcelas; i++)
            {
                var vencimentoParcelaAtual = CalcularDataVencimentoParcela(parcelas[i - 1].DataVencimento);
                var diasEntreParcelas = CalcularDiasEntreParcelas(vencimentoParcelaAtual, i.Equals(1) ? despesa.DataOperacao : parcelas[i - 1].DataVencimento);
                var saldoInicial = i.Equals(1) ? valorFinanciado : parcelas[1 - 1].SaldoFinal;
                var jurosParcela = CalcularJurosParcela(despesa.CustoEfetivoTotalDia, diasEntreParcelas, saldoInicial);

                var despesaParcela = new DespesaParcela()
                {
                    Id = Guid.NewGuid(),
                    DataVencimento = i.Equals(1) ? despesa.DataVencimentoPrimeiraParcela : vencimentoParcelaAtual,
                    ParcelaNumero = i,
                    DiasEntreParcelas = diasEntreParcelas,
                    SaldoInicial = saldoInicial,
                    Juros = jurosParcela
                };
                parcelas.Add(despesaParcela);
            }
            
            return parcelas;
        }

        private DateTimeOffset CalcularDataVencimentoParcela (DateTimeOffset vencimentoAnterior)
        {
            var novoVencimento = vencimentoAnterior.AddDays(30);

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

            return (decimal)resultado;
        }

        public void Dispose()
        {
            _despesaRepository.Dispose();
        }
    }
}