using AgendaContatos.Domain.Entities;
using AgendaContatos.Domain.Interfaces.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatos.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<Guid> Adicionar(Usuario entidade)
        {
            return Task.FromResult(Guid.NewGuid());
        }

        public Task<bool> ExisteRegistro(Func<Usuario, bool> consulta)
        {
            return Task.FromResult(false);
        }

        public IQueryable Selecionar(Func<Usuario, bool> consulta)
        {
            throw new NotImplementedException();
        }
    }
}
