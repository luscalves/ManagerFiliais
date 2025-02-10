using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class ProjetosValidator : AbstractValidator<Projetos>
    {
        public ProjetosValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(p => p.DataInicio)
                .NotEmpty().WithMessage("Por favor informe a data de início.")
                .NotNull().WithMessage("Por favor informe a data de início.");

            RuleFor(p => p.IdDepartamento)
                .NotEmpty().WithMessage("Por favor informe o departamento.")
                .NotNull().WithMessage("Por favor informe o departamento.");
        }
    }
}