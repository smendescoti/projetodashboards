using OfficeOpenXml;
using ProjetoDashboards.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDashboards.Presentation.Reports
{
    public class ExcelReport
    {
        public static byte[] GenerateReport
            (DateTime dataMin, DateTime dataMax, List<MovimentacoesResultadoModel> model)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var excel = new ExcelPackage())
            {
                var planilha = excel.Workbook.Worksheets.Add("Movimentações");

                planilha.Cells["A1"].Value = "Relatório de Movimentações Financeiras";

                planilha.Cells["A3"].Value = "Data de início:";
                planilha.Cells["B3"].Value = dataMin.ToString("dd/MM/yyyy");

                planilha.Cells["A4"].Value = "Data de término:";
                planilha.Cells["B4"].Value = dataMax.ToString("dd/MM/yyyy");

                planilha.Cells["A6"].Value = "Nome da Movimentação";
                planilha.Cells["B6"].Value = "Data";
                planilha.Cells["C6"].Value = "Valor";
                planilha.Cells["D6"].Value = "Tipo";

                var linha = 7;
                foreach (var item in model)
                {
                    planilha.Cells[$"A{linha}"].Value = item.NomeMovimentacao;
                    planilha.Cells[$"B{linha}"].Value = item.DataMovimentacao.ToString("dd/MM/yyyy");
                    planilha.Cells[$"C{linha}"].Value = item.ValorMovimentacao.ToString("c");
                    planilha.Cells[$"D{linha}"].Value = item.TipoMovimentacao.ToString();

                    linha++;
                }

                //formatações
                planilha.Cells["A1:D1"].Merge = true;
                planilha.Cells["A:D"].AutoFitColumns();

                return excel.GetAsByteArray();
            }
        }
    }
}
