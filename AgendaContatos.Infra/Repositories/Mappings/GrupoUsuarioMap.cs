using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class GrupoUsuarioMap : IEntityTypeConfiguration<GrupoUsuario>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuario> builder)
        {
            builder
                .HasKey(gu => new { gu.IdGrupo, gu.IdUsuario });
            builder
                .HasOne(gu => gu.Grupo)
                .WithMany(g => g.GruposUsuarios)
                .HasForeignKey(gu => gu.IdGrupo);
            builder
                .HasOne(gu => gu.Usuario)
                .WithMany(u => u.GruposUsuarios)
                .HasForeignKey(gu => gu.IdUsuario);
        }
    }
}
