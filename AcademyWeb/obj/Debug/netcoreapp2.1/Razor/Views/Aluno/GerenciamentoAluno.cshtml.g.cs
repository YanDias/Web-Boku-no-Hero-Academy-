#pragma checksum "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b0b5e98efb2857f927e9fe0c1458851c9f364a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_GerenciamentoAluno), @"mvc.1.0.view", @"/Views/Aluno/GerenciamentoAluno.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aluno/GerenciamentoAluno.cshtml", typeof(AspNetCore.Views_Aluno_GerenciamentoAluno))]
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
#line 1 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\_ViewImports.cshtml"
using AcademyWeb;

#line default
#line hidden
#line 2 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b0b5e98efb2857f927e9fe0c1458851c9f364a", @"/Views/Aluno/GerenciamentoAluno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3337a21e0e2b86cbd4b516f94de48624622a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_GerenciamentoAluno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aluno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
  
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(67, 34, true);
            WriteLiteral("\n<h2>Gerenciamento de Alunos</h2>\n");
            EndContext();
            BeginContext(101, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe1992f6d644e8581b91a181182eac3", async() => {
                BeginContext(148, 15, true);
                WriteLiteral("Cadastrar Aluno");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 286, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped""
       style=""margin-top:15px;margin-bottom:15px"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>CPF</th>
            <th>Imagem</th>
            <th>Criado em</th>
            
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
         foreach (Aluno item in Model)
        {

#line default
#line hidden
            BeginContext(502, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(540, 9, false);
#line 24 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(549, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(576, 8, false);
#line 25 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
               Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(584, 48, true);
            WriteLiteral("</td>\n\n                <td>\n                    ");
            EndContext();
            BeginContext(632, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a61719f20264efdbec8ef8b742debbb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 642, "~/Academyimagens/", 642, 17, true);
#line 28 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
AddHtmlAttributeValue("", 659, item.Imagem, 659, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
AddHtmlAttributeValue("", 703, item.Nome, 703, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(775, 45, true);
            WriteLiteral("\n                </td>\n\n\n                <td>");
            EndContext();
            BeginContext(821, 13, false);
#line 34 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
               Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(834, 40, true);
            WriteLiteral("</td>\n               \n            </tr>\n");
            EndContext();
#line 37 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\GerenciamentoAluno.cshtml"
        }

#line default
#line hidden
            BeginContext(884, 115, true);
            WriteLiteral("    </tbody>\n</table>\n<br /><br />\n<a href=\"https://localhost:44312/Imc/\" class=\"btn btn-success\">Avaliação IMC</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
