using System;
using System.ComponentModel.DataAnnotations;
using BoxBack.Application.ViewModels.Selects;

namespace BoxBack.Application.ViewModels
{
    public class DespesaViewModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Forma pagamento requerida.")]
        public string FormaPagamento { get; set; }
        public string SistemaParcelamento { get; set; }
        public Int64? TotalParcelas { get; set; }
        public string DataOperacao { get; set; }
        
        [Range(typeof(decimal), "1", "79228162514264337593543950335", ErrorMessage = "O valor principal deve ser um número decimal positivo.")]
        public decimal ValorPrincipal { get; set; }

        public decimal? Iof { get; set; } = 0;
        public decimal? Seguro { get; set; } = 0;
        public decimal? Tarifa { get; set; } = 0;
        public decimal? CustoEfetivoTotalAno { get; set; } = 0;
        public decimal? CustoEfetivoTotalMes { get; set; } = 0;
        public decimal? CustoEfetivoTotalDia { get; set; } = 0;
        public decimal? ValorEntrada { get; set; } = 0;
        public decimal? ValorParcelado { get; set; } = 0;
        public string Status { get; set; }
        public Guid? ClienteId { get; set; }
        public string DataVencimentoPrimeiraParcela { get; set; }
        
        [Required(ErrorMessage = "Cliente requerido.")]
        public ClienteSelect2ViewModel Cliente { get; set; }

        public Guid? PessoaId { get; set; }

        [Required(ErrorMessage = "Credor requerido.")]
        public PessoaSelect2ViewModel Pessoa { get; set; }
    }
}