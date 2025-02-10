using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class FiliaisValidator : AbstractValidator<Filiais>
    {
        public FiliaisValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(f => f.Endereco)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .MaximumLength(255).WithMessage("Endereço pode ter no máximo 255 caracteres.");

            RuleFor(f => f.Telefone)
                .NotEmpty().WithMessage("Por favor informe o telefone.")
                .MaximumLength(20).WithMessage("Telefone pode ter no máximo 20 caracteres.");
        }
    }
}