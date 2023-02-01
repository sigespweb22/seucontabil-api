using BoxBack.Domain.Models;
using FluentValidation;

namespace BoxBack.Domain.Validators.VendedorComissaoValidator
{
    public class ClienteParamsValidator : AbstractValidator<Cliente>
    {
        public ClienteParamsValidator()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id cliente requerido.");
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id cliente requerido.");
        }
    }
}