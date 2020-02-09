using AgendaContatos.Domain.Entities;
using AgendaContatos.Infra.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AgendaContatos.Infra.Repositories
{
    public partial class AgendaContatoContext: DbContext
    {
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Envio> Envio { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Contato> Contato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampanhaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnvioMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
