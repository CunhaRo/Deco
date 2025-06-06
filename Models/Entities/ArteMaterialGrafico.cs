using System.ComponentModel.DataAnnotations;

namespace Deco.Models.Entities
{
    public class ArteMaterialGrafico
    {
        [Display(Name = "Id")]
        public Guid ArteMaterialGraficoId { get; set; }
        [Display(Name = "Expectativa De Atendimento")]
        public DateTime? ExpectativaDeAtendimento { get; set; }
        [Display(Name = "Tipo de Material")]
        public string? TipoDeMaterial { get; set; }
        [Display(Name = "Público Alvo")]
        public string? PublicoAlvo { get; set; }
        [Display(Name = "Detalhes do Material")]
        public string? DetalheDoMaterial { get; set; }

        public Guid SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } = null!;
    }
}
