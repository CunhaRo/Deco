using Deco.Models.Entities;
using Deco.Repositories.Interfaces;
using Deco.Services.Interfaces;

namespace Deco.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly ISolicitacaoRepository _solicitacaoRepository;
        private readonly IDivulgacaoRepository _divulgacaoRepository;
        private readonly IArteMaterialGraficoRepository _arteMaterialGraficoRepository;
        private readonly ICoberturaRepository _coberturaRepository;

        public SolicitacaoService(ISolicitacaoRepository solicitacaoRepository, IDivulgacaoRepository divulgacaoRepository, IArteMaterialGraficoRepository arteMaterialGraficoRepository, ICoberturaRepository coberturaRepository)
        {
            _solicitacaoRepository = solicitacaoRepository;
            _divulgacaoRepository = divulgacaoRepository;
            _arteMaterialGraficoRepository = arteMaterialGraficoRepository;
            _coberturaRepository = coberturaRepository;
        }

        public async Task AdicionarSolicitacaoComTipoAsync(Solicitacao solicitacao)
        {
            var solicitacaoModel = new Solicitacao
            {
                SolicitacaoId = Guid.NewGuid(),
                Tipo = solicitacao.Tipo,
                Situacao = "Aguardando Atendimento",
                Telefone = solicitacao.Telefone,
                Whatsapp = solicitacao.Whatsapp,
                Email = solicitacao.Email,
                Responsavel = solicitacao.Responsavel,
                Objetivo = solicitacao.Objetivo,
                IsAprovadaPeloGestor = solicitacao.IsAprovadaPeloGestor,
                DataDaSolicitacao = DateTime.Now,
            };

            await _solicitacaoRepository.AdicionarAsync(solicitacaoModel);

            switch (solicitacao.Tipo)
            {
                case "Divulgação":
                    var divulgacao = new Divulgacao
                    {
                        DivulgacaoId = Guid.NewGuid(),
                        SolicitacaoId = solicitacaoModel.SolicitacaoId,
                        DataHoraDaPublicacao = solicitacao.Divulgacao.DataHoraDaPublicacao,
                        Mensagem = solicitacao.Divulgacao.Mensagem
                    };
                    await _divulgacaoRepository.AdicionarAsync(divulgacao);
                    break;

                case "Arte/Material Gráfico":
                    var arte = new ArteMaterialGrafico
                    {
                        ArteMaterialGraficoId = Guid.NewGuid(),
                        SolicitacaoId = solicitacaoModel.SolicitacaoId,
                        ExpectativaDeAtendimento = solicitacao.ArteMaterialGrafico.ExpectativaDeAtendimento,
                        TipoDeMaterial = solicitacao.ArteMaterialGrafico.TipoDeMaterial,
                        PublicoAlvo = solicitacao.ArteMaterialGrafico.PublicoAlvo,
                        DetalheDoMaterial = solicitacao.ArteMaterialGrafico.DetalheDoMaterial
                    };
                    await _arteMaterialGraficoRepository.AdicionarAsync(arte);
                    break;

                case "Cobertura":
                    var cobertura = new Cobertura
                    {
                        CoberturaId = Guid.NewGuid(),
                        SolicitacaoId = solicitacaoModel.SolicitacaoId,
                        DataHoraDoEvento = solicitacao.Cobertura.DataHoraDoEvento,
                        DescricaoDoEvento = solicitacao.Cobertura.DescricaoDoEvento,
                        Local = solicitacao.Cobertura.Local,
                        NumeroDeParticipante = solicitacao.Cobertura.NumeroDeParticipante,
                        MembroPresente = solicitacao.Cobertura.MembroPresente
                    };
                    await _coberturaRepository.AdicionarAsync(cobertura);
                    break;

                default:
                    throw new InvalidOperationException("Tipo de solicitação inválido.");
            }
        }

        public async Task<List<Solicitacao>> BuscarTodasComIncludeAsync()
        {
            return await _solicitacaoRepository.BuscarTodasComIncludeAsync();
        }
    }
}
