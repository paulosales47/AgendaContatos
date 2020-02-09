using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("TB_GRUPO");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Nicho).IsRequired();
        }
    }
}
