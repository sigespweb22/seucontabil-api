using System;
using BoxBack.Application.ViewModels.Selects;

namespace BoxBack.Application.ViewModels
{
    public class DespesaViewModel
    {
        public Guid? Id { get; set; }
        public string FormaPagamento { get; set; }
        public string SistemaParcelamento { get; set; }
        public Int64 TotalParcelas { get; set; }
        public string DataOperacao { get; set; }
        public decimal? ValorPrincipal { get; set; }
        public decimal? Iof { get; set; }
        public decimal? Seguro { get; set; }
        public decimal? Tarifa { get; set; }
        public decimal? CustoEfetivoTotalAno { get; set; }
        public decimal? CustoEfetivoTotalMes { get; set; }
        public decimal? CustoEfetivoTotalDia { get; set; }
        public decimal? ValorEntrada { get; set; }
        public decimal? ValorParcelado { get; set; }
        public string Status { get; set; }
        public Guid? ClienteId { get; set; }
        public ClienteSelect2ViewModel Cliente { get; set; }
        public Guid? PessoaId { get; set; }
        public PessoaSelect2ViewModel Pessoa { get; set; }
    }
}