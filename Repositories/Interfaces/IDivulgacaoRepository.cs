using Deco.Models.Entities;

namespace Deco.Repositories.Interfaces
{
    public interface IDivulgacaoRepository
    {
        Task AdicionarAsync(Divulgacao divulgacao);
    }
}
