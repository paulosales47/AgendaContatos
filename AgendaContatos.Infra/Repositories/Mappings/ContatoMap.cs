using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("TB_CONTATO");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Telefone).HasMaxLength(30).IsRequired();
            builder.Property(u => u.Nicho).IsRequired();

            builder.HasOne(u => u.Usuario).WithMany().HasForeignKey("ID_USUARIO");
        }
    }
}
