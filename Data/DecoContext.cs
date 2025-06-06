using Deco.Data.EntityConfig;
using Deco.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Deco.Data
{
    public class DecoContext : DbContext
    {
        public DecoContext(DbContextOptions<DecoContext> options) : base(options)
        {
        }

        public DbSet<Solicitacao> Solicitacoes { get; set; } = null!;
        public DbSet<Divulgacao> Divulgacoes { get; set; } = null!;
        public DbSet<Cobertura> Coberturas { get; set; } = null!;
        public DbSet<ArteMaterialGrafico> ArtesMateriaisGraficos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SolicitacaoConfig());
            modelBuilder.ApplyConfiguration(new DivulgacaoConfig());
            modelBuilder.ApplyConfiguration(new CoberturaConfig());
            modelBuilder.ApplyConfiguration(new ArteMaterialGraficoConfig());
        }
    }
}
