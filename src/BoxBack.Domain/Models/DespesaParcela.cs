using System;
using System.ComponentModel.DataAnnotations.Schema;
using BoxBack.Domain.Enums;

namespace BoxBack.Domain.Models
{
    public class DespesaParcela : EntityAuditTenant
    {        
        public DespesaParcela(DateTimeOffset dataVencimento, Int32 parcelaNumero,
                              Int32 diasEntreParcelas,
                              decimal saldoInicial, decimal saldoFinal,
                              decimal juros, decimal amortizacao,
                              decimal valorParcela)
        {
            DataVencimento = dataVencimento;
            ParcelaNumero = parcelaNumero;
            DiasEntreParcelas = diasEntreParcelas;
            SaldoInicial = saldoInicial;
            SaldoFinal = saldoFinal;
            Juros = juros;
            Amortizacao = amortizacao;
            ValorParcela = valorParcela;
        }

        // Constructor empty for EF
        public DespesaParcela() {}


        public DateTimeOffset DataVencimento { get; set; }
        public Int32 ParcelaNumero { get; set; }
        public Int32 DiasEntreParcelas { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal Juros { get; set; }
        public decimal Amortizacao { get; set; }
        public decimal ValorParcela { get; set; }


        // Relationships
        [ForeignKey("DespesaId")]
        public Guid DespesaId {get; set; }
        public Despesa Despesa {get; set; }
    }
}
