using Deco.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Deco.Data.EntityConfig
{
    public class SolicitacaoConfig : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("Solicitacoes");

            builder.HasKey(s => s.SolicitacaoId);

            builder.Property(s => s.SolicitacaoId)
                .HasDefaultValueSql("NEWID()");

            builder.Property(s => s.Tipo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Telefone)
                .HasMaxLength(20);

            builder.Property(s => s.Whatsapp)
               .HasMaxLength(20);

            builder.Property(s => s.Email)
                .HasMaxLength(250);
            builder.Property(s => s.Responsavel)
                .HasMaxLength(250);
            builder.Property(s => s.Objetivo)
                .HasMaxLength(250);

            builder.Property(s => s.IsAprovadaPeloGestor)
                .HasDefaultValue(false);

            builder.Property(s => s.Situacao)
                .HasMaxLength(30);

            builder.Property(s => s.DataDaSolicitacao)
                .HasDefaultValueSql("GETDATE()");


            builder.HasOne(s => s.Divulgacao)
                .WithOne(d => d.Solicitacao)
                .HasForeignKey<Divulgacao>(d => d.SolicitacaoId);

            builder.HasOne(s => s.Cobertura)
                .WithOne(c => c.Solicitacao)
                .HasForeignKey<Cobertura>(c => c.SolicitacaoId);

            builder.HasOne(s => s.ArteMaterialGrafico)
                .WithOne(a => a.Solicitacao)
                .HasForeignKey<ArteMaterialGrafico>(a => a.SolicitacaoId);
        }
    }
}
