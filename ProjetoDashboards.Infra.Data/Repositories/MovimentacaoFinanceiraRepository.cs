using ProjetoDashboards.Domain.Contracts.Repositories;
using ProjetoDashboards.Domain.Entities;
using ProjetoDashboards.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDashboards.Infra.Data.Repositories
{
    public class MovimentacaoFinanceiraRepository
        : BaseRepository<MovimentacaoFinanceira>, IMovimentacaoFinanceiraRepository
    {
        //atributo
        private readonly DataContext dataContext;

        //construtor para inicialização do atributo
        public MovimentacaoFinanceiraRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<MovimentacaoFinanceira> GetAll(DateTime dataMin, DateTime dataMax)
        {
            //SQL ->    select * from MovimentacaoFinanceira
            //          where Data >= @dataMin && Data <= @dataMax
            //          order by Data desc

            return dataContext.MovimentacaoFinanceira
                    .Where(m => m.Data >= dataMin && m.Data <= dataMax)
                    .OrderByDescending(m => m.Data)
                    .ToList();
        }
    }
}
