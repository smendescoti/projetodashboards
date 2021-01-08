using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjetoDashboards.Application.Models
{
    public class MovimentacoesCadastroModel
    {
        [MinLength(4, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome da movimentação")]
        public string NomeMovimentacao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da movimentação")]
        public string DataMovimentacao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o valor da movimentação")]
        public string ValorMovimentacao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo da movimentação")]
        public string TipoMovimentacao { get; set; }
    }
}
