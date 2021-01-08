using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Application.Models
{
    public class MovimentacoesResultadoModel
    {
        public Guid IdMovimentacao { get; set; }
        public string NomeMovimentacao { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal ValorMovimentacao { get; set; }
        public string TipoMovimentacao { get; set; }
    }
}
