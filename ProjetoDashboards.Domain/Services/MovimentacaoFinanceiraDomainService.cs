using ProjetoDashboards.Domain.Contracts.Repositories;
using ProjetoDashboards.Domain.Contracts.Services;
using ProjetoDashboards.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Domain.Services
{
    public class MovimentacaoFinanceiraDomainService 
        : IMovimentacaoFinanceiraDomainService
    {
        //atributo..
        private readonly IMovimentacaoFinanceiraRepository movimentacaoFinanceiraRepository;

        //construtor para injeção de dependencia (inicialização)
        public MovimentacaoFinanceiraDomainService(IMovimentacaoFinanceiraRepository movimentacaoFinanceiraRepository)
        {
            this.movimentacaoFinanceiraRepository = movimentacaoFinanceiraRepository;
        }

        public void Cadastrar(MovimentacaoFinanceira movimentacaoFinanceira)
        {
            #region Não é permitido cadastrar movimentações para datas anteriores à data atual

            if(movimentacaoFinanceira.Data 
                < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0))
            {
                throw new Exception("Não é permitido cadastrar movimentações para datas anteriores à data atual.");
            }

            movimentacaoFinanceiraRepository.Create(movimentacaoFinanceira);

            #endregion
        }

        public void Atualizar(MovimentacaoFinanceira movimentacaoFinanceira)
        {
            #region Não é permitido atualizar movimentações para datas anteriores à data atual

            if (movimentacaoFinanceira.Data
                < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0))
            {
                throw new Exception("Não é permitido atualizar movimentações para datas anteriores à data atual.");
            }

            movimentacaoFinanceiraRepository.Update(movimentacaoFinanceira);

            #endregion
        }

        public void Excluir(MovimentacaoFinanceira movimentacaoFinanceira)
        {
            movimentacaoFinanceiraRepository.Delete(movimentacaoFinanceira);
        }

        public List<MovimentacaoFinanceira> Consultar(DateTime dataMin, DateTime dataMax)
        {
            #region A data de inicio do periodo deve ser menor ou igual a data fim do periodo

            if(dataMin > dataMax)
            {
                throw new Exception("A data de inicio do periodo deve ser menor ou igual a data fim do periodo.");
            }

            #endregion

            return movimentacaoFinanceiraRepository.GetAll(dataMin, dataMax);
        }

        public MovimentacaoFinanceira ObterPorId(Guid id)
        {
            return movimentacaoFinanceiraRepository.GetById(id);
        }
    }
}
