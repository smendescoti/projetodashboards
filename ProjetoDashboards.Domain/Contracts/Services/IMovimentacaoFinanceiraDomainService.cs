using ProjetoDashboards.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Domain.Contracts.Services
{
    public interface IMovimentacaoFinanceiraDomainService
    {
        void Cadastrar(MovimentacaoFinanceira movimentacaoFinanceira);
        void Atualizar(MovimentacaoFinanceira movimentacaoFinanceira);
        void Excluir(MovimentacaoFinanceira movimentacaoFinanceira);

        List<MovimentacaoFinanceira> Consultar(DateTime dataMin, DateTime dataMax);
        MovimentacaoFinanceira ObterPorId(Guid id);
    }
}
