using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class CampanhaMap : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.ToTable("TB_CAMPANHA");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(150).IsRequired();

            builder.HasOne(u => u.Usuario).WithMany().HasForeignKey("ID_USUARIO");
        }
    }
}
