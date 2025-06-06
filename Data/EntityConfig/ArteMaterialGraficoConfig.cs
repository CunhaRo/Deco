using Deco.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Deco.Data.EntityConfig
{
    public class ArteMaterialGraficoConfig : IEntityTypeConfiguration<ArteMaterialGrafico>
    {
        public void Configure(EntityTypeBuilder<ArteMaterialGrafico> builder)
        {
            builder.ToTable("ArtesMateriaisGraficos");

            builder.HasKey(a => a.ArteMaterialGraficoId);

            builder.Property(a => a.ArteMaterialGraficoId)
                .HasDefaultValueSql("NEWID()");

            builder.Property(a => a.TipoDeMaterial)
                .HasMaxLength(100);

            builder.Property(a => a.PublicoAlvo)
                .HasMaxLength(250);

            builder.Property(a => a.DetalheDoMaterial)
                .HasMaxLength(500);

            builder.HasOne(a => a.Solicitacao)
                .WithOne(s => s.ArteMaterialGrafico)
                .HasForeignKey<ArteMaterialGrafico>(a => a.SolicitacaoId)
                .IsRequired();
        }
    }
}
