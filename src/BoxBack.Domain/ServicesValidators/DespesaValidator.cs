using BoxBack.Domain.Models;
using FluentValidation;

namespace BoxBack.Domain.ServicesValidators
{
    public class DespesaValidator : AbstractValidator<Despesa>
    {
        public DespesaValidator()
        {
            RuleFor(x => x.FormaPagamento).NotNull().WithMessage("Forma de pagamento requerida.");
            RuleFor(x => x.ValorPrincipal).NotEmpty().WithMessage("Valor principal da despesa requerido.");
            RuleFor(x => x.ClienteId).NotEmpty().WithMessage("Cliente requerido.");
            RuleFor(x => x.PessoaId).NotEmpty().WithMessage("Credor requerido.");
        }
    }
}