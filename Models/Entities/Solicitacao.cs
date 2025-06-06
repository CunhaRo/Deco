using System.ComponentModel.DataAnnotations;

namespace Deco.Models.Entities
{
    public class Solicitacao
    {
        [Display(Name = "Id")]
        public Guid SolicitacaoId { get; set; }

        [Display(Name = "Tipo")]
        public string? Tipo { get; set; }

        [Display(Name = "Telefone")]
        public string? Telefone{ get; set; }

        [Display(Name = "Whatsapp")]
        public string? Whatsapp { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Display(Name = "Pessoa ou Equipe Responsavel")]
        public string? Responsavel { get; set; }

        [Display(Name = "Justificativa")]
        public string? Objetivo { get; set; }

        [Display(Name = "A solicitação está aprovada pelo seu gestor imediato?")]
        public bool IsAprovadaPeloGestor { get; set; }
        [Display(Name = "Situação")]
        public string? Situacao { get; set; }
        [Display(Name = "Data da Solicitação")]
        public DateTime DataDaSolicitacao { get; set; }

        public Divulgacao? Divulgacao { get; set; } = new Divulgacao();
        public Cobertura? Cobertura { get; set; } = new Cobertura();
        public ArteMaterialGrafico? ArteMaterialGrafico { get; set; } = new ArteMaterialGrafico();
    }
}
