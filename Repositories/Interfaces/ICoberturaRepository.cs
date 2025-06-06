using Deco.Models.Entities;

namespace Deco.Repositories.Interfaces
{
    public interface ICoberturaRepository
    {
        Task AdicionarAsync(Cobertura cobertura);
    }
}
