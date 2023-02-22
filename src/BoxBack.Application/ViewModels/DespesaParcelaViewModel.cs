using System;
namespace BoxBack.Application.ViewModels
{
    public class DespesaParcelaViewModel
    {
        public Guid? Id { get; set; }
        public string DataVencimento { get; set; }
        public Int32 ParcelaNumero { get; set; }
        public Int32? DiasEntreParcelas { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal? SaldoFinal { get; set; }
        public decimal? Juros { get; set; }
        public decimal? Amortizacao { get; set; }
        public decimal ValorParcela { get; set; }
        public string Status { get; set; }
    }
}