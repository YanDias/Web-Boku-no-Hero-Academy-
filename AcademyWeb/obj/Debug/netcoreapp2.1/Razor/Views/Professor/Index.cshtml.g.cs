#pragma checksum "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06cd90bff5790edca3651191436034299f39d196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professor/Index.cshtml", typeof(AspNetCore.Views_Professor_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06cd90bff5790edca3651191436034299f39d196", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3337a21e0e2b86cbd4b516f94de48624622a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Professor>>
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
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
  
    DateTime dataHora = ViewBag.DataHora;
    

#line default
#line hidden
            BeginContext(76, 50, true);
            WriteLiteral("\n<h2>Gerenciamento de Professor</h2>\n<br /><br />\n");
            EndContext();
            BeginContext(126, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0776159f04a041818d637dd0ad6d9864", async() => {
                BeginContext(173, 19, true);
                WriteLiteral("Cadastrar Professor");
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
            BeginContext(196, 321, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped""
       style=""margin-top:15px;margin-bottom:15px"">
    <thead>
        <tr>
            <th>Nome</th>
            <th>CPF</th>
            <th>Imagem</th>
            <th>Especialidade</th>
            <th>Criado em</th>
            
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 24 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
         foreach (Professor item in Model)
        {

#line default
#line hidden
            BeginContext(570, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(608, 9, false);
#line 27 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(617, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(644, 8, false);
#line 28 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
               Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(652, 48, true);
            WriteLiteral("</td>\n\n                <td>\n                    ");
            EndContext();
            BeginContext(700, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c9890163b5a4088ab752b5710124888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 710, "~/Academyimagens/", 710, 17, true);
#line 31 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
AddHtmlAttributeValue("", 727, item.Imagem, 727, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
AddHtmlAttributeValue("", 771, item.Nome, 771, 10, false);

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
            BeginContext(843, 43, true);
            WriteLiteral("\n                </td>\n                <td>");
            EndContext();
            BeginContext(887, 18, false);
#line 35 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
               Write(item.Especialidade);

#line default
#line hidden
            EndContext();
            BeginContext(905, 27, true);
            WriteLiteral("</td>\n\n                <td>");
            EndContext();
            BeginContext(933, 13, false);
#line 37 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
               Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(946, 41, true);
            WriteLiteral("</td>\n                \n            </tr>\n");
            EndContext();
#line 40 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(997, 52, true);
            WriteLiteral("    </tbody>\n</table>\n<b>Dados atualizados em: </b> ");
            EndContext();
            BeginContext(1050, 8, false);
#line 43 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Professor\Index.cshtml"
                         Write(dataHora);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Professor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
