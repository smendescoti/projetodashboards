using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDashboards.Application.Contracts;
using ProjetoDashboards.Application.Models;
using ProjetoDashboards.Presentation.Reports;

namespace ProjetoDashboards.Presentation.Controllers
{
    public class MovimentacoesController : Controller
    {
        //atributo
        private readonly IMovimentacaoFinanceiraApplicationService movimentacaoFinanceiraApplicationService;

        //construtor para injeção de dependência (inicialização)
        public MovimentacoesController(IMovimentacaoFinanceiraApplicationService movimentacaoFinanceiraApplicationService)
        {
            this.movimentacaoFinanceiraApplicationService = movimentacaoFinanceiraApplicationService;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(MovimentacoesCadastroModel model)
        {
            //verificar se todos os campos passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    movimentacaoFinanceiraApplicationService.Cadastrar(model);

                    TempData["MensagemSucesso"] = $"Movimentação '{model.NomeMovimentacao}', cadastrada com sucesso.";
                    ModelState.Clear(); //limpa o conteudo do formulário
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Consulta(MovimentacoesConsultaModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //pesquisando as movimentações por datas..
                    var resultado = movimentacaoFinanceiraApplicationService.Consultar(model);
                    //enviando o resultado da pesquisa para a página
                    TempData["Resultado"] = resultado;

                    if (resultado.Count == 0)
                        TempData["MensagemAlerta"] = "Nenhuma movimentação foi encontrada para o periodo especificado.";
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Relatorio(MovimentacoesRelatorioModel model)
        {
            if(ModelState.IsValid)
            {
                var consulta = new MovimentacoesConsultaModel
                {
                    DataInicio = model.DataInicio,
                    DataTermino = model.DataTermino
                };

                //consultando as movimentações
                var dados = movimentacaoFinanceiraApplicationService.Consultar(consulta);

                try
                {
                    //verificar o tipo do relatorio
                    switch(model.TipoRelatorio)
                    {
                        case "EXCEL":
                            var relatorioExcel = ExcelReport.GenerateReport
                                (DateTime.Parse(model.DataInicio), DateTime.Parse(model.DataTermino), dados);

                            //download do arquivo
                            Response.Clear();
                            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            Response.Headers.Add("content-disposition", "attachment; filename=relatorio.xlsx");
                            Response.Body.WriteAsync(relatorioExcel, 0, relatorioExcel.Length);
                            Response.Body.Flush();
                            Response.StatusCode = StatusCodes.Status200OK;

                            break;

                        case "PDF":

                            var relatorioPDF = PDFReport.GenerateReport
                                (DateTime.Parse(model.DataInicio), DateTime.Parse(model.DataTermino), dados);

                            //download do arquivo
                            Response.Clear();
                            Response.ContentType = "application/pdf";
                            Response.Headers.Add("content-disposition", "attachment; filename=relatorio.pdf");
                            Response.Body.WriteAsync(relatorioPDF, 0, relatorioPDF.Length);
                            Response.Body.Flush();
                            Response.StatusCode = StatusCodes.Status200OK;

                            break;
                    }
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View();
        }

        public IActionResult Edicao(Guid id)
        {
            var model = new MovimentacoesEdicaoModel();

            try
            {
                //buscar o registro da movimentação pelo id..
                var resultado = movimentacaoFinanceiraApplicationService.ObterPorId(id);

                //transferindo as informações
                model.IdMovimentacao = resultado.IdMovimentacao;
                model.NomeMovimentacao = resultado.NomeMovimentacao;
                model.DataMovimentacao = resultado.DataMovimentacao.ToString("yyyy-MM-dd");
                model.ValorMovimentacao = resultado.ValorMovimentacao.ToString();
                model.TipoMovimentacao = resultado.TipoMovimentacao.Equals("Receita") ? "1" : "2";
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = e.Message;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edicao(MovimentacoesEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    movimentacaoFinanceiraApplicationService.Atualizar(model);
                    TempData["MensagemSucesso"] = "Movimentação atualizada com sucesso.";

                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }

            return View();
        }

        public IActionResult Excluir(Guid id)
        {
            try
            {
                //excluindo a movimentação financeira
                movimentacaoFinanceiraApplicationService.Excluir(id);

                TempData["MensagemSucesso"] = "Movimentação excluída com sucesso.";
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = e.Message;
            }

            //redirecionamento
            return RedirectToAction("Consulta");
        }

        //método para retornar os dados do gráfico..
        public JsonResult ObterMovimentacoes(MovimentacoesConsultaModel model)
        {
            try
            {
                //consultando todas as movimentações:
                var dados = movimentacaoFinanceiraApplicationService.Consultar(model);

                //retornando o total de receitas e despesas:
                var totalReceitas = new 
                {
                    Name = "Receitas",
                    Data = new List<decimal>
                    { dados.Where(m => m.TipoMovimentacao.Equals("Receita")).Sum(m => m.ValorMovimentacao) } 
                };

                var totalDespesas = new
                {
                    Name = "Despesas",
                    Data = new List<decimal>
                    { dados.Where(m => m.TipoMovimentacao.Equals("Despesa")).Sum(m => m.ValorMovimentacao) }
                };

                return Json(new { totalReceitas, totalDespesas });
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}
