using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class FuncionariosValidator : AbstractValidator<Funcionarios>
    {
        public FuncionariosValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(f => f.Cargo)
                .MaximumLength(100).WithMessage("Cargo pode ter no máximo 100 caracteres.");

            RuleFor(f => f.IdFilial)
                .NotEmpty().WithMessage("Por favor informe a filial.")
                .NotNull().WithMessage("Por favor informe a filial.");
        }
    }
}