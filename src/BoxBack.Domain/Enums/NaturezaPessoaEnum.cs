using System.ComponentModel.DataAnnotations;

namespace BoxBack.Domain.Enums
{
    public enum NaturezaPessoaEnum
    {
        [Display(Name = "Credor")]
        CREDOR = 1,

        [Display(Name = "Fornecedor")]
        FORNECEDOR = 2
    }
}