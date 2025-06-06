using Deco.Models.Entities;

namespace Deco.Repositories.Interfaces
{
    public interface IArteMaterialGraficoRepository
    {
        Task AdicionarAsync(ArteMaterialGrafico arte);
    }
}
