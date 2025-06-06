using Deco.Data;
using Deco.Models.Entities;
using Deco.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Deco.Repositories
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {
        private readonly DecoContext _decoContext;

        public SolicitacaoRepository(DecoContext decoContext)
        {
            _decoContext = decoContext;
        }

        public async Task AdicionarAsync(Solicitacao solicitacao)
        {
            solicitacao.Divulgacao = null;
            solicitacao.ArteMaterialGrafico = null;
            solicitacao.Cobertura = null;

            _decoContext.Solicitacoes.Add(solicitacao);
            await _decoContext.SaveChangesAsync();
        }

        public async Task<List<Solicitacao>> BuscarTodasComIncludeAsync()
        {
            return await _decoContext.Solicitacoes
                .Include(s => s.Divulgacao)
                .Include(s => s.ArteMaterialGrafico)
                .Include(s => s.Cobertura)
                .ToListAsync();
        }
    }
}
