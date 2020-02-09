using AgendaContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaContatos.Infra.Repositories.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_USUARIO");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.PrimeiroNome).HasMaxLength(150).IsRequired();
            builder.Property(u => u.UltimoNome).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(200).IsRequired();
            builder.Property(u => u.Senha).IsRequired();
            builder.Property(u => u.DataCadastro).IsRequired();
            builder.Property(u => u.Ativo).IsRequired();
        }
    }
}

