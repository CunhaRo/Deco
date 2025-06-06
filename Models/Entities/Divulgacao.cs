using System.ComponentModel.DataAnnotations;

namespace Deco.Models.Entities
{
    public class Divulgacao
    {
        [Display(Name = "Id")]
        public Guid DivulgacaoId { get; set; }
        [Display(Name = "Data/Hora de Publicação")]
        public DateTime? DataHoraDaPublicacao { get; set; }

        [Display(Name = "Descrição")]
        public string? Mensagem { get; set; }   
        public Guid SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; } = null!;
    }
}
