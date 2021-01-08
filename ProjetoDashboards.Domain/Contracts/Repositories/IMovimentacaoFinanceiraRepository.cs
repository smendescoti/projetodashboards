using ProjetoDashboards.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Domain.Contracts.Repositories
{
    public interface IMovimentacaoFinanceiraRepository
        : IBaseRepository<MovimentacaoFinanceira>
    {
        List<MovimentacaoFinanceira> GetAll(DateTime dataMin, DateTime dataMax);
    }
}
