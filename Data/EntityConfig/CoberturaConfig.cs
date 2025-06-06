using Deco.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Deco.Data.EntityConfig
{
    public class CoberturaConfig : IEntityTypeConfiguration<Cobertura>
    {
        public void Configure(EntityTypeBuilder<Cobertura> builder)
        {
            builder.ToTable("Coberturas");

            builder.HasKey(c => c.CoberturaId);

            builder.Property(c => c.CoberturaId)
                .HasDefaultValueSql("NEWID()");

            builder.Property(c => c.DescricaoDoEvento)
                .HasMaxLength(500);

            builder.Property(c => c.Local)
                .HasMaxLength(250);

            builder.Property(c => c.MembroPresente)
                .HasMaxLength(500);

            builder.HasOne(c => c.Solicitacao)
                .WithOne(s => s.Cobertura)
                .HasForeignKey<Cobertura>(c => c.SolicitacaoId)
                .IsRequired();
        }
    }
}
