using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDashboards.Application.Models
{
    public class MovimentacoesConsultaModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string DataTermino { get; set; }
    }
}
