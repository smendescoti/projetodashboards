using ProjetoDashboards.Application.Contracts;
using ProjetoDashboards.Application.Models;
using ProjetoDashboards.Domain.Contracts.Services;
using ProjetoDashboards.Domain.Entities;
using ProjetoDashboards.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Application.Services
{
    public class MovimentacaoFinanceiraApplicationService
        : IMovimentacaoFinanceiraApplicationService
    {
        //atributo
        private readonly IMovimentacaoFinanceiraDomainService movimentacaoFinanceiraDomainService;

        //construtor para inicialização do atributo..
        public MovimentacaoFinanceiraApplicationService(IMovimentacaoFinanceiraDomainService movimentacaoFinanceiraDomainService)
        {
            this.movimentacaoFinanceiraDomainService = movimentacaoFinanceiraDomainService;
        }

        public void Cadastrar(MovimentacoesCadastroModel model)
        {
            var movimentacaoFinanceira = new MovimentacaoFinanceira
            {
                Id = Guid.NewGuid(),
                Nome = model.NomeMovimentacao,
                Data = DateTime.Parse(model.DataMovimentacao),
                Valor = decimal.Parse(model.ValorMovimentacao),
                TipoMovimentacao = (TipoMovimentacao) int.Parse(model.TipoMovimentacao)
            };

            movimentacaoFinanceiraDomainService.Cadastrar(movimentacaoFinanceira);
        }

        public void Atualizar(MovimentacoesEdicaoModel model)
        {
            var movimentacaoFinanceira = new MovimentacaoFinanceira
            {
                Id = model.IdMovimentacao,
                Nome = model.NomeMovimentacao,
                Data = DateTime.Parse(model.DataMovimentacao),
                Valor = decimal.Parse(model.ValorMovimentacao),
                TipoMovimentacao = (TipoMovimentacao) int.Parse(model.TipoMovimentacao)
            };

            movimentacaoFinanceiraDomainService.Atualizar(movimentacaoFinanceira);
        }

        public void Excluir(Guid id)
        {
            var movimentacaoFinanceira = movimentacaoFinanceiraDomainService.ObterPorId(id);
            movimentacaoFinanceiraDomainService.Excluir(movimentacaoFinanceira); //excluindo..
        }

        public List<MovimentacoesResultadoModel> Consultar(MovimentacoesConsultaModel model)
        {
            var lista = new List<MovimentacoesResultadoModel>();

            foreach (var item in movimentacaoFinanceiraDomainService
                .Consultar(DateTime.Parse(model.DataInicio), DateTime.Parse(model.DataTermino)))
            {
                lista.Add(
                    new MovimentacoesResultadoModel
                    {
                        IdMovimentacao = item.Id,
                        NomeMovimentacao = item.Nome,
                        DataMovimentacao = item.Data,
                        ValorMovimentacao = item.Valor,
                        TipoMovimentacao = item.TipoMovimentacao.ToString()
                    }
                    );
            }

            return lista;
        }

        public MovimentacoesResultadoModel ObterPorId(Guid id)
        {
            var item = movimentacaoFinanceiraDomainService.ObterPorId(id);

            return new MovimentacoesResultadoModel
            {
                IdMovimentacao = item.Id,
                NomeMovimentacao = item.Nome,
                DataMovimentacao = item.Data,
                ValorMovimentacao = item.Valor,
                TipoMovimentacao = item.TipoMovimentacao.ToString()
            };
        }
    }
}
