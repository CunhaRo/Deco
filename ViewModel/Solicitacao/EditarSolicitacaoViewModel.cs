using System;
using System.ComponentModel.DataAnnotations;
using Deco.Models.Entities;
using Microsoft.AspNetCore.Http;



namespace Deco.ViewModel.Solicitacao
{
    public class EditarSolicitacaoViewModel
    {
        public EditarSolicitacaoViewModel() {
            
        }
        public Guid Id { get; set; }

        [Display(Name = "Responsável")]
        public string Responsavel { get; set; }

        [Display(Name = "Justificativa")]
        public string Objetivo { get; set; }

        public Divulgacao? Divulgacao { get; set; } = new Divulgacao();

    }
}
