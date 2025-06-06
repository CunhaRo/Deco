using Deco.Models.Entities;
using Deco.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Deco.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly ISolicitacaoService _solicitacaoService;

        public SolicitacaoController(ISolicitacaoService solicitacaoService)
        {
            _solicitacaoService = solicitacaoService;
        }

        public async Task<IActionResult> Index()
        {
            var solicitacoes = await _solicitacaoService.BuscarTodasComIncludeAsync();
            
            return View(solicitacoes);
        }

        public IActionResult Divulgacao()
        {
            return View();
        }

        public async Task<IActionResult> AdicionarDivulgacao(Solicitacao solicitacao)
        {
            solicitacao.Tipo = "Divulgação";
            await _solicitacaoService.AdicionarSolicitacaoComTipoAsync(solicitacao);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ArteMaterialGrafico()
        {
            return View();
        }

        public async Task<IActionResult> AdicionarArteMaterialGrafico(Solicitacao solicitacao)
        {
            solicitacao.Tipo = "Arte/Material Gráfico";
            await _solicitacaoService.AdicionarSolicitacaoComTipoAsync(solicitacao);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Cobertura()
        {
            return View();
        }

        public async Task<IActionResult> AdicionarCobertura(Solicitacao solicitacao)
        {
            solicitacao.Tipo = "Cobertura";
            await _solicitacaoService.AdicionarSolicitacaoComTipoAsync(solicitacao);
            return RedirectToAction(nameof(Index));
        }

        private static List<string> TiposDeSolicitacoes()
        {
            return
            [
                "Divulgação",
                "Arte/Material Gráfico",
                "Cobertura"
            ];
        }
    }
}
