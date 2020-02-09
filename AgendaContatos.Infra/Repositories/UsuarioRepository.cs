using AgendaContatos.Domain.Entities;
using AgendaContatos.Infra.Repositories.Base;
using System;

namespace AgendaContatos.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario, Guid>
    {
        public UsuarioRepository(AgendaContatoContext context) : base(context)
        {
        }
    }
}
