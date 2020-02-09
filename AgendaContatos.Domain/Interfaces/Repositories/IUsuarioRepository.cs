using AgendaContatos.Domain.Entities;
using AgendaContatos.Domain.Interfaces.Repositories.Base;
using System;

namespace AgendaContatos.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository: IRepositoryBase<Usuario, Guid> { }
}
