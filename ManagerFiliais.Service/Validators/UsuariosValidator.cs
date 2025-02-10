using FluentValidation;
using ManagerFiliais.Domain.Entities;

namespace ManagerFiliais.Service.Validators
{
    public class UsuariosValidator : AbstractValidator<Usuarios>
    {
        public UsuariosValidator()
        {
            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .MaximumLength(100).WithMessage("Nome pode ter no máximo 100 caracteres.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .EmailAddress().WithMessage("Por favor informe um email válido.")
                .MaximumLength(100).WithMessage("Email pode ter no máximo 100 caracteres.");

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .MaximumLength(255).WithMessage("Senha pode ter no máximo 255 caracteres.");
        }
    }
}