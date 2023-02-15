using BoxBack.Domain.Models;
using FluentValidation;

namespace BoxBack.Domain.ServicesValidators
{
    public class DespesaParcelaValidator : AbstractValidator<DespesaParcela>
    {
        public DespesaParcelaValidator()
        {
            RuleFor(x => x.DespesaId).NotEmpty().WithMessage("ID da despesa requerido.");
        }
    }
}