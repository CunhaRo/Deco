using Deco.Models.Entities;

namespace Deco.Repositories.Interfaces
{
    public interface ISolicitacaoRepository
    {
        Task AdicionarAsync(Solicitacao solicitacaoModel);
        Task<List<Solicitacao>> BuscarTodasComIncludeAsync();
    }
}   
