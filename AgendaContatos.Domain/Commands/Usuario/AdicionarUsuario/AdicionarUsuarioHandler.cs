using AgendaContatos.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AgendaContatos.Domain.Entities;

namespace AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public AdicionarUsuarioHandler(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            var response = new Response();
            bool emailExistente = await EmailExistente(request).ConfigureAwait(false);

            if (emailExistente)
                response.AdicionarNotificacao("E-mail cadastrado", "O e-mail informado já está sendo utilizado");

            var usuario = new Entities.Usuario(
                primeiroNome: request.PrimeiroNome,
                ultimoNome: request.UltimoNome,
                email: request.Email,
                senha: request.Senha);

            await _repositoryUsuario.Adicionar(usuario).ConfigureAwait(false);
            
            return response;
        }

        private async Task<bool> EmailExistente(AdicionarUsuarioRequest request)
        {
            return await _repositoryUsuario.ExisteRegistro(u => u.Email.Equals(request.Email)).ConfigureAwait(false);
        }
    }
}
