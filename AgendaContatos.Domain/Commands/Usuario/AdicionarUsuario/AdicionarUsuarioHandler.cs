﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioHandler : IRequestHandler<AdicionarUsuarioRequest, Response>
    {
        public async Task<Response> Handle(AdicionarUsuarioRequest request, CancellationToken cancellationToken)
        {
            return null;

        }
    }
}