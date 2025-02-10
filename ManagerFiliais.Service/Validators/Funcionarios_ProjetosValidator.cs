using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class FuncionariosProjetosValidator : AbstractValidator<FuncionariosProjetos>
    {
        public FuncionariosProjetosValidator()
        {
            RuleFor(fp => fp.CargoProjeto)
                .NotEmpty().WithMessage("Por favor informe o cargo no projeto.")
                .NotEmpty().WithMessage("Por favor informe o cargo no projeto.")
                .MaximumLength(50).WithMessage("Cargo no projeto pode ter no máximo 50 caracteres.");

            RuleFor(fp => fp.DataParticipacao)
                .NotEmpty().WithMessage("Por favor informe a data de participação.")
                .NotNull().WithMessage("Por favor informe a data de participação.");

            RuleFor(fp => fp.IdFuncionario)
                .NotEmpty().WithMessage("Por favor informe o funcionário.")
                .NotNull().WithMessage("Por favor informe o funcionário.");

            RuleFor(fp => fp.IdProjeto)
                .NotEmpty().WithMessage("Por favor informe o projeto.")
                .NotNull().WithMessage("Por favor informe o projeto.");
        }
    }
}