using AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario;
using FluentValidation;

namespace AgendaContatos.Domain.Validator
{
    public class AdicionarUsuarioValidator : AbstractValidator<AdicionarUsuarioRequest>
    {
        public AdicionarUsuarioValidator()
        {
            RuleFor(a => a.PrimeiroNome)
                .NotEmpty()
                .WithMessage("Necessário informar o primeiro nome");

            RuleFor(a => a.UltimoNome)
                .NotEmpty()
                .WithMessage("Necessário informar o ultimo nome");

            RuleFor(a => a.Senha)
                .NotEmpty()
                .Length(8, 16)
                .WithMessage("A senha deve ter de 8 a 16 caracteres");

            RuleFor(a => a.Email)
                .NotEmpty()
                .MinimumLength(4)
                .WithMessage("O e-mail deve ter no minimo 4 caracteres")
                .NotEmpty()
                .WithMessage("É necessário informar o e-mail");
        }
    }
}
