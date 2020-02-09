using System;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatos.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntidade, TId>
    {
        IQueryable Selecionar(Func<TEntidade, bool> consulta);
        Task<bool> ExisteRegistro(Func<TEntidade, bool> consulta);
        Task<TId> Adicionar(TEntidade entidade);
    }
}
