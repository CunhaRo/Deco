using Deco.Data;
using Deco.Models.Entities;
using Deco.Repositories.Interfaces;

namespace Deco.Repositories
{
    public class CoberturaRepository : ICoberturaRepository
    {
        private readonly DecoContext _decoContext;

        public CoberturaRepository(DecoContext decoContext)
        {
            _decoContext = decoContext;
        }

        public async Task AdicionarAsync(Cobertura cobertura)
        {
            _decoContext.Coberturas.Add(cobertura);
            await _decoContext.SaveChangesAsync();
        }
    }
}
