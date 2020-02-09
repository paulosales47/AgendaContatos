using AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario;
using AgendaContatos.Domain.Core;
using AgendaContatos.Domain.Interfaces.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.Handlers.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediator _mediator;

        public AdicionarUsuarioHandler(IUsuarioRepository usuarioRepository, IMediator mediator)
        {
            _usuarioRepository = usuarioRepository;
            _mediator = mediator;
        }

        public async Task<Response> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            var response = new Response();
            bool emailExistente = EmailExistente(request);

            if (emailExistente)
                response.AdicionarNotificacao("E-mail cadastrado", "O e-mail informado já está sendo utilizado");

            var usuario = new Entities.Usuario(
                primeiroNome: request.PrimeiroNome,
                ultimoNome: request.UltimoNome,
                email: request.Email,
                senha: request.Senha);

            _usuarioRepository.Adicionar(usuario);

            await _mediator.Publish(new AdicionarUsuarioNotification(usuario)).ConfigureAwait(false);

            return await Task.FromResult(new Response("Usuário adicionado com sucesso")).ConfigureAwait(false);
        }

        private bool EmailExistente(AdicionarUsuarioRequest request)
        {
            return _usuarioRepository.ExisteRegistro(u => u.Email.Equals(request.Email));
        }
    }
}
