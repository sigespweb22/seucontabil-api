using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BoxBack.Domain.Enums;

namespace BoxBack.Domain.Models
{
    public class Despesa : EntityAuditTenant
    {        
        public Despesa(FormaPagamentoEnum formaPagamento,
                       SistemaParcelamentoEnum sistemaParcelamento,
                       Int32 totalParcelas, DateTimeOffset dataOperacao,
                       decimal valorPrincipal, decimal iof, decimal seguro,
                       decimal tarifa, decimal custoEfetivoTotalAno,
                       decimal custoEfetivoTotalMes, decimal custoEfetivoTotalDia,
                       decimal valorEntrada, decimal valorParcelado)
        {
            FormaPagamento = formaPagamento;
            SistemaParcelamento = sistemaParcelamento;
            TotalParcelas = totalParcelas;
            DataOperacao = dataOperacao;
            ValorPrincipal = valorPrincipal;
            Iof = iof;
            Seguro = seguro;
            Tarifa = tarifa;
            CustoEfetivoTotalAno = custoEfetivoTotalAno;
            CustoEfetivoTotalMes = custoEfetivoTotalMes;
            CustoEfetivoTotalDia = custoEfetivoTotalDia;
            ValorEntrada = valorEntrada;
            ValorParcelado = valorParcelado;
        }

        // Constructor empty for EF
        public Despesa() {}

        public FormaPagamentoEnum FormaPagamento { get; set; }
        public SistemaParcelamentoEnum SistemaParcelamento { get; set; }
        public Int32 TotalParcelas { get; set; }
        public DateTimeOffset DataOperacao { get; set; }
        public decimal ValorPrincipal { get; set; }
        public decimal Iof { get; set; }
        public decimal Seguro { get; set; }
        public decimal Tarifa { get; set; }
        public decimal CustoEfetivoTotalAno { get; set; }
        public decimal CustoEfetivoTotalMes { get; set; }
        public decimal CustoEfetivoTotalDia { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorParcelado { get; set; }

        // Relationships
        public ICollection<DespesaParcela> DespesaParcelas { get; set; }

        [ForeignKey("ClienteId")]
        public Guid ClienteId { get; set; }
        public Cliente Cliente  {get; set; }

        [ForeignKey("CredorId")]
        public Guid CredorId { get; set; }
        public Credor credor { get; set; }
    }
}
