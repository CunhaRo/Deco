using Deco.Data;
using Deco.Models.Entities;
using Deco.Repositories.Interfaces;

namespace Deco.Repositories
{
    public class DivulgacaoRepository : IDivulgacaoRepository
    {
        private readonly DecoContext _decoContext;

        public DivulgacaoRepository(DecoContext decoContext)
        {
            _decoContext = decoContext;
        }

        public async Task AdicionarAsync(Divulgacao divulgacao)
        {
            _decoContext.Divulgacoes.Add(divulgacao);
            await _decoContext.SaveChangesAsync();
        }
    }
}
