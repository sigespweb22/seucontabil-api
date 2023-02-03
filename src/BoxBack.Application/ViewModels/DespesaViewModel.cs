using System;
using BoxBack.Domain.Models;

namespace BoxBack.Application.ViewModels
{
    public class DespesaViewModel
    {
        public Guid? Id { get; set; }
        public string FormaPagamento { get; set; }
        public string SistemaParcelamento { get; set; }
        public string TotalParcelas { get; set; }
        public string DataOperacao { get; set; }
        public decimal ValorPrincipal { get; set; }
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
        public Cliente Cliente { get; set; }
    }
}