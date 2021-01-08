#pragma checksum "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6353f652367a33e48988d34d9b523602db78e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6353f652367a33e48988d34d9b523602db78e9", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>Sistema de controle de movimentações financeiras</h5>
<p>Seja bem vindo ao projeto!</p>
<hr />

<div class=""row"">
    <div class=""col-md-3"">

        <label>Data de Início:</label>
        <input type=""date"" id=""dataMin"" class=""form-control""/>
        <br/>

        <label>Data de Término:</label>
        <input type=""date"" id=""dataMax"" class=""form-control""/>
        <br/>

        <button id=""btnFiltro"" class=""btn btn-success"">
            Filtrar Resultados
        </button>

    </div>
    <div class=""col-md-9"">
        <div id=""grafico""></div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/highcharts-3d.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>

    <script>

        //iniciando o jquery..
        $(document).ready(function () {

            //obtendo o primeiro e o ultimo dia do mes atual..
            var date = new Date();
            var dataMin = new Date(date.getFullYear(), date.getMonth(), 1);
            var dataMax = new Date(date.getFullYear(), date.getMonth() + 1, 0);

            //setar as datas nos campos
            $(""#dataMin"").val(formatDate(dataMin));
            $(""#dataMax"").val(formatDate(dataMax));

            //gerando o gráfico assim que a página for carregada..
            gerarGrafico();

            //evento para clicar no botão..
            $(""#btnFiltro"").click(function () {
                gerarG");
                WriteLiteral(@"rafico();
            })
        });

        //função para gerar o gráfico..
        function gerarGrafico() {

            //Requisição AJAX para o controller..
            $.ajax({
                type: ""POST"",
                url: ""/Movimentacoes/ObterMovimentacoes"",
                data: {
                    DataInicio: $(""#dataMin"").val(),
                    DataTermino: $(""#dataMax"").val()
                },
                success: function (result) {

                    var array = [];

                    array.push([
                        result.totalReceitas.name, result.totalReceitas.data[0]
                    ]);

                    array.push([
                        result.totalDespesas.name, result.totalDespesas.data[0]
                    ]);

                    new Highcharts.Chart({
                        chart: {
                            type: 'pie',
                            renderTo: 'grafico'
                        },
                    ");
                WriteLiteral(@"    title: {
                            verticalAlign: 'middle',
                            floating: true,
                            text: 'Movimentações<br/>Financeiras<br/><br/>'
                                + $(""#dataMin"").val() + '<br/>'
                                + $(""#dataMax"").val()
                        },
                        plotOptions: {
                            pie: {
                                innerSize: '75%',
                                dataLabels: {
                                    enable: true
                                },
                                showInLegend: true
                            }
                        },
                        credits: {
                            enabled : false
                        },
                        series: [{
                            data : array
                        }],
                        colors : ['#5cb85c', '#d9534f']
                    });

               ");
                WriteLiteral(@" }
            });

        }

        //função para formatar as data no padrão do campo type='date'
        function formatDate(date) {
            var d = new Date(date),
                month = '' + (d.getMonth() + 1),
                day = '' + d.getDate(),
                year = d.getFullYear();

            if (month.length < 2)
                month = '0' + month;
            if (day.length < 2)
                day = '0' + day;

            return [year, month, day].join('-');
        }

    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
