using System.ComponentModel.DataAnnotations;

namespace BoxBack.Domain.Enums
{
    public enum SistemaParcelamentoEnum
    {
        [Display(Name = "Sistema PRICE")]
        TABELA_PRICE = 0,

        [Display(Name = "SAC - Sistema de amortização constante")]
        TABELA_SAC = 1,
    }
}