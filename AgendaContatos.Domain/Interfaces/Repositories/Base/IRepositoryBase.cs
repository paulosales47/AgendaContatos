using System;
using System.Linq;

namespace AgendaContatos.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntidade, TId>
        where TEntidade : class
        where TId : struct
    {
        IQueryable Selecionar(Func<TEntidade, bool> consulta);
        bool ExisteRegistro(Func<TEntidade, bool> consulta);
        TEntidade Adicionar(TEntidade entidade);
    }
}
