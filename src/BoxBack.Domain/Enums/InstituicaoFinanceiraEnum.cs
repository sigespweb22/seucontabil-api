using System.ComponentModel.DataAnnotations;

namespace BoxBack.Domain.Enums
{
    public enum InstituicaoFinanceiraEnum
    {
        [Display(Name = "Banco Bradesco")]
        BRADESCO = 0,
        
        [Display(Name = "Banco Itaú")]
        ITAÚ = 1,

        [Display(Name = "Banco Inter")]
        INTER = 2,

        [Display(Name = "Nubank")]
        NUBANK = 3,

        [Display(Name = "Caixa econômica federal")]
        CAIXA_ECONOMICA_FEDERAL = 4,

        [Display(Name = "Banco do Brasil")]
        BANCO_DO_BRASIL = 5,

        [Display(Name = "Sicred")]
        SICRED = 6,

        [Display(Name = "SICOOB")]
        SICOOB = 7,

        [Display(Name = "UNICRED")]
        UNICRED = 8,

        [Display(Name = "Banco Santander")]
        SANTANDER = 9,

        [Display(Name = "Banco Votorantim")]
        VOTORANTIM = 10,

        [Display(Name = "Banrisul")]
        BANRISUL = 11,

        [Display(Name = "Citibank Brasil")]
        CITIBANK = 12,

        [Display(Name = "Banco Safra")]
        SAFRA = 13,

        [Display(Name = "BTG Pactual")]
        BTG_PACTUAL = 14,

        [Display(Name = "Banco Nordeste")]
        BANCO_NORDESTE = 15
    }
}