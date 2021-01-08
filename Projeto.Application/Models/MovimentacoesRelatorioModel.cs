using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDashboards.Application.Models
{
    public class MovimentacoesRelatorioModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string DataTermino { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo de término.")]
        public string TipoRelatorio { get; set; }
    }
}
