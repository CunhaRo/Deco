using Deco.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Deco.Data.EntityConfig
{
    public class DivulgacaoConfig : IEntityTypeConfiguration<Divulgacao>
    {
        public void Configure(EntityTypeBuilder<Divulgacao> builder)
        {
            builder.ToTable("Divulgacoes");

            builder.HasKey(d => d.DivulgacaoId);

            builder.Property(d => d.DivulgacaoId)
                .HasDefaultValueSql("NEWID()");

            builder.Property(d => d.Mensagem)
                .HasMaxLength(500);

            builder.HasOne(d => d.Solicitacao)
                .WithOne(s => s.Divulgacao)
                .HasForeignKey<Divulgacao>(d => d.SolicitacaoId)
                .IsRequired();
        }
    }
}
