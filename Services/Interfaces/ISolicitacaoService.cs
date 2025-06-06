using Deco.Models.Entities;

namespace Deco.Services.Interfaces
{
    public interface ISolicitacaoService
    {
        Task AdicionarSolicitacaoComTipoAsync(Solicitacao solicitacao);
        Task<List<Solicitacao>> BuscarTodasComIncludeAsync();
    }
}
