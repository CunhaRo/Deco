using Deco.Data;
using Deco.Models.Entities;
using Deco.Repositories.Interfaces;

namespace Deco.Repositories
{
    public class ArteMaterialGraficoRepository : IArteMaterialGraficoRepository
    {
        private readonly DecoContext _decoContext;

        public ArteMaterialGraficoRepository(DecoContext decoContext)
        {
            _decoContext = decoContext;
        }

        public async Task AdicionarAsync(ArteMaterialGrafico arteMaterialGrafico)
        {
            _decoContext.ArtesMateriaisGraficos.Add(arteMaterialGrafico);
            await _decoContext.SaveChangesAsync();
        }
    }
}
