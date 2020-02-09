using AgendaContatos.Domain.Core;
using MediatR;

namespace AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioRequest: IRequest<Response>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public AdicionarUsuarioRequest(string primeiroNome, string ultimoNome, string senha, string email)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Senha = senha;
            Email = email;
        }

        public AdicionarUsuarioRequest()
        {

        }
    }
}
