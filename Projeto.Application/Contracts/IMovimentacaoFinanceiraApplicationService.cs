using ProjetoDashboards.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Application.Contracts
{
    public interface IMovimentacaoFinanceiraApplicationService
    {
        void Cadastrar(MovimentacoesCadastroModel model);
        void Atualizar(MovimentacoesEdicaoModel model);
        void Excluir(Guid id);

        List<MovimentacoesResultadoModel> Consultar(MovimentacoesConsultaModel model);
        MovimentacoesResultadoModel ObterPorId(Guid id);
    }
}
