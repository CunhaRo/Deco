using System.ComponentModel.DataAnnotations;

namespace Deco.Models.Entities
{
    public class Cobertura
    {
        [Display(Name = "Id")]
        public Guid CoberturaId { get; set; }
        [Display(Name = "Data/Hora do Evento")]
        public DateTime? DataHoraDoEvento { get; set; }
        [Display(Name = "Descrição do Evento")]
        public string? DescricaoDoEvento { get; set; }
        [Display(Name = "Local")]
        public string? Local { get; set; }
        [Display(Name = "Número de Participantes")]
        public int? NumeroDeParticipante { get; set; }
        [Display(Name = "Membros Presentes")]
        public string? MembroPresente { get; set; }

        public Guid SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } = null!;
    }
}
