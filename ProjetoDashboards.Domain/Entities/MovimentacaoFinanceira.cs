using ProjetoDashboards.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Domain.Entities
{
    public class MovimentacaoFinanceira
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        #region Relacionamentos

        public TipoMovimentacao TipoMovimentacao { get; set; }

        #endregion
    }
}
