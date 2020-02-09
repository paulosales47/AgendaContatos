using AgendaContatos.Domain.Entities.Base;
using AgendaContatos.Domain.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AgendaContatos.Infra.Repositories.Base
{
    public abstract class RepositoryBase<TEntidade, TId> : IRepositoryBase<TEntidade, TId>
        where TEntidade : EntityBase
        where TId : struct
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public TEntidade Adicionar(TEntidade entidade)
        {
            var entidadeAdicionada = _context.Add<TEntidade>(entidade);

            return entidadeAdicionada.Entity;
        }

        public bool ExisteRegistro(Func<TEntidade, bool> consulta)
        {
            return _context.Set<TEntidade>().Any(consulta);
        }

        public IQueryable Selecionar(Func<TEntidade, bool> consulta)
        {
            throw new NotImplementedException();
        }
    }
}
