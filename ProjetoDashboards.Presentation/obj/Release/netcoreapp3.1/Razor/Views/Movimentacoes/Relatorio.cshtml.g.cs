#pragma checksum "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89a9e2332408727c64f3def822e44c60f1a4569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimentacoes_Relatorio), @"mvc.1.0.view", @"/Views/Movimentacoes/Relatorio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89a9e2332408727c64f3def822e44c60f1a4569", @"/Views/Movimentacoes/Relatorio.cshtml")]
    public class Views_Movimentacoes_Relatorio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoDashboards.Application.Models.MovimentacoesRelatorioModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
  
    ViewData["Title"] = "Relatorio";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Relatório de Movimentações financeiras</h5>\r\n<p>Informe o período de datas e o formato desejado:</p>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n\r\n        ");
#nullable restore
#line 16 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
   Write(Html.TextBoxFor(model => model.DataInicio,
            new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 19 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
       Write(Html.ValidationMessageFor(model => model.DataInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n\r\n        ");
#nullable restore
#line 25 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
   Write(Html.TextBoxFor(model => model.DataTermino,
            new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 28 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
       Write(Html.ValidationMessageFor(model => model.DataTermino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n\r\n        ");
#nullable restore
#line 34 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
   Write(Html.RadioButtonFor(model => model.TipoRelatorio, "PDF"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Formato PDF</span> <br />\r\n        ");
#nullable restore
#line 35 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
   Write(Html.RadioButtonFor(model => model.TipoRelatorio, "EXCEL"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Formato Excel</span> <br />\r\n\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 38 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"
       Write(Html.ValidationMessageFor(model => model.TipoRelatorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <input type=\"submit\" value=\"Gerar Relatório\"\r\n               class=\"btn btn-success\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 47 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Relatorio.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoDashboards.Application.Models.MovimentacoesRelatorioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
