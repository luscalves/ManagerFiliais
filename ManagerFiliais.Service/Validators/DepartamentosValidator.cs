using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class DepartamentosValidator : AbstractValidator<Departamentos>
    {
        public DepartamentosValidator()
        {
            RuleFor(d => d.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(d => d.IdFilial)
                .NotEmpty().WithMessage("Por favor informe a filial.")
                .NotNull().WithMessage("Por favor informe a filial.");
        }
    }
}