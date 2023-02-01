using BoxBack.Domain.Models;
using FluentValidation;

namespace BoxBack.Domain.Validators.ClienteValidator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x).Empty().WithMessage("Nenhum cliente encontrado.");
            RuleFor(x => x.Id).NotNull().WithMessage("Id cliente requerido.");
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id cliente requerido.");
        }
    }
}