using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class EnvioMap : IEntityTypeConfiguration<Envio>
    {
        public void Configure(EntityTypeBuilder<Envio> builder)
        {
            builder.ToTable("TB_ENVIO");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Enviado).IsRequired();

            builder.HasOne(u => u.Campanha).WithOne().HasForeignKey("ID_CAMPANHA");
        }
    }
}
