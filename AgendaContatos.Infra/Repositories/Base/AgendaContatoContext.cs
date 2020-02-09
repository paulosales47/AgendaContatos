using AgendaContatos.Domain.Entities;
using AgendaContatos.Infra.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AgendaContatos.Infra.Repositories
{
    public partial class AgendaContatoContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        
        public AgendaContatoContext(DbContextOptions<AgendaContatoContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupoUsuarioMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
