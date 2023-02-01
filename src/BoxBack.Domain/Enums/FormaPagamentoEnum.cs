using System.ComponentModel.DataAnnotations;

namespace BoxBack.Domain.Enums
{
    public enum FormaPagamentoEnum
    {
        [Display(Name = "À Vista")]
        AVISTA = 0,

        [Display(Name = "Parcelada")]
        PARCELADA = 1
    }
}