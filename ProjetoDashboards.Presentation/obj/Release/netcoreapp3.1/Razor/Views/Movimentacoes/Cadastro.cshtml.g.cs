#pragma checksum "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaaaf94ff853476612efe696bc134807c736a3fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimentacoes_Cadastro), @"mvc.1.0.view", @"/Views/Movimentacoes/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaaaf94ff853476612efe696bc134807c736a3fa", @"/Views/Movimentacoes/Cadastro.cshtml")]
    public class Views_Movimentacoes_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoDashboards.Application.Models.MovimentacoesCadastroModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Cadastro de Movimentações financeiras</h5>\r\n<p>Preencha o formulário abaixo:</p>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n\r\n            <label>Nome da Movimentação</label>\r\n            ");
#nullable restore
#line 17 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.NomeMovimentacao,
                new { @class = "form-control", @placeholder = "Digite aqui" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
#nullable restore
#line 20 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.NomeMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Data da Movimentação</label>\r\n            ");
#nullable restore
#line 25 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.DataMovimentacao,
                new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
#nullable restore
#line 28 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.DataMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Valor da Movimentação</label>\r\n            ");
#nullable restore
#line 33 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.ValorMovimentacao,
                new { @class = "form-control", @placeholder = "0.00" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"text-danger\">\r\n                ");
#nullable restore
#line 36 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.ValorMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Tipo da Movimentação</label> <br />\r\n            ");
#nullable restore
#line 41 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
       Write(Html.RadioButtonFor(model => model.TipoMovimentacao, "1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Receita</span> <br />\r\n            ");
#nullable restore
#line 42 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
       Write(Html.RadioButtonFor(model => model.TipoMovimentacao, "2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Despesa</span> <br />\r\n            <span class=\"text-danger\">\r\n                ");
#nullable restore
#line 44 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.TipoMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <input type=\"submit\" value=\"Cadastrar Movimentação\"\r\n                   class=\"btn btn-success\" />\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\sergi\OneDrive\Área de Trabalho\Aulas EAD\C# .NET - SQS Noite 03\Aula 39 - 18.12.2020\ProjetoDashboards\ProjetoDashboards.Presentation\Views\Movimentacoes\Cadastro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoDashboards.Application.Models.MovimentacoesCadastroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591