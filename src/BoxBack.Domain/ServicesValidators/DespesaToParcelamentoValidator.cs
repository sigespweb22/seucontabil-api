using BoxBack.Domain.Models;
using FluentValidation;

namespace BoxBack.Domain.ServicesValidators
{
    public class DespesaToParcelamentoValidator : AbstractValidator<Despesa>
    {
        public DespesaToParcelamentoValidator()
        {
            RuleFor(x => x.ValorPrincipal).NotEmpty().WithMessage("Valor principal requerido.");
            RuleFor(x => x.TotalParcelas).NotEqual(0).WithMessage("Total parcelas requerido.");
            RuleFor(x => x.CustoEfetivoTotalAno).NotEmpty().WithMessage("Custo efetivo ao ano requerido.");
            RuleFor(x => x.CustoEfetivoTotalMes).NotEmpty().WithMessage("Custo efetivo ao mês requerido.");
            RuleFor(x => x.CustoEfetivoTotalDia).NotEmpty().WithMessage("Custo efetivo ao dia requerido.");
            RuleFor(x => x.DataVencimentoPrimeiraParcela).NotNull().WithMessage("Data vencimento primeira parcela requerida.");
            RuleFor(x => x.DataOperacao).NotNull().WithMessage("Data operação requerida.");
        }
    }
}