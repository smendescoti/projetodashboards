using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using ProjetoDashboards.Application.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDashboards.Presentation.Reports
{
    public class PDFReport
    {
        public static byte[] GenerateReport
            (DateTime dataMin, DateTime dataMax, List<MovimentacoesResultadoModel> model)
        {
            var memoryStream = new MemoryStream();
            var pdf = new PdfDocument(new PdfWriter(memoryStream));

            using (var document = new Document(pdf))
            {
                document.Add(new Paragraph("Relatório de Movimentações Financeiras"));
                document.Add(new Paragraph($"Data de início: {dataMin.ToString("dd/MM/yyyy")}"));
                document.Add(new Paragraph($"Data de término: {dataMax.ToString("dd/MM/yyyy")}"));

                var table = new Table(4);
                table.AddHeaderCell("Nome da Movimentação");
                table.AddHeaderCell("Data da Movimentação");
                table.AddHeaderCell("Valor em R$");
                table.AddHeaderCell("Tipo");

                foreach (var item in model)
                {
                    table.AddCell(item.NomeMovimentacao);
                    table.AddCell(item.DataMovimentacao.ToString("dd/MM/yyyy"));
                    table.AddCell(item.ValorMovimentacao.ToString("c"));
                    table.AddCell(item.TipoMovimentacao.ToString());
                }

                document.Add(table);                
            }

            //retornar os dados do arquivo..
            return memoryStream.ToArray();
        }
    }
}
