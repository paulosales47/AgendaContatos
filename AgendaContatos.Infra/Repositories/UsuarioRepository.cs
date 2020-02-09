using AgendaContatos.Domain.Entities;
using AgendaContatos.Domain.Interfaces.Repositories;
using AgendaContatos.Infra.Repositories.Base;
using System;

namespace AgendaContatos.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario, Guid>, IUsuarioRepository
    {
        public UsuarioRepository(AgendaContatoContext context) : base(context)
        {
        }
    }
}
