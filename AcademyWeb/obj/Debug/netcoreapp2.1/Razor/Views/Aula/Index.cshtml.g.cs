#pragma checksum "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ba89714738a2b494ad129727bd105cd1593163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aula_Index), @"mvc.1.0.view", @"/Views/Aula/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aula/Index.cshtml", typeof(AspNetCore.Views_Aula_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ba89714738a2b494ad129727bd105cd1593163", @"/Views/Aula/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3337a21e0e2b86cbd4b516f94de48624622a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Aula_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aula>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
  
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(66, 80, true);
            WriteLiteral("    <center>\n        <h2>Gerenciamento de Aulas</h2>\n    </center>\n<br /><br />\n");
            EndContext();
            BeginContext(146, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc02d256f00e44c6bb1f57efd85f6182", async() => {
                BeginContext(193, 14, true);
                WriteLiteral("Cadastrar Aula");
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
            BeginContext(211, 322, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped""
       style=""margin-top:15px;margin-bottom:15px"">
    <thead>
        <tr>
            <th>Tipo</th>
            <th>Local</th>
            <th>Dia</th>
            <th>Vagas</th>
            <th>Professor</th>
            <th></th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
         foreach (Aula item in Model)
        {

#line default
#line hidden
            BeginContext(581, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(619, 9, false);
#line 28 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
               Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(628, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(655, 10, false);
#line 29 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
               Write(item.Local);

#line default
#line hidden
            EndContext();
            BeginContext(665, 27, true);
            WriteLiteral("</td>\n\n                <td>");
            EndContext();
            BeginContext(693, 9, false);
#line 31 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
               Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(702, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(729, 10, false);
#line 32 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
               Write(item.Vagas);

#line default
#line hidden
            EndContext();
            BeginContext(739, 27, true);
            WriteLiteral("</td>\n\n                <td>");
            EndContext();
            BeginContext(767, 19, false);
#line 34 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
               Write(item.Professor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(786, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(833, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fff980d275a423080a8bda745790ac4", async() => {
                BeginContext(954, 53, true);
                WriteLiteral("\n                        Remover\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
                         WriteLiteral(item.IdAula);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1011, 59, true);
            WriteLiteral("\n                </td>\n                }\n            </tr>\n");
            EndContext();
#line 44 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1080, 52, true);
            WriteLiteral("    </tbody>\n</table>\n<b>Dados atualizados em: </b> ");
            EndContext();
            BeginContext(1133, 8, false);
#line 47 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aula\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Aula>> Html { get; private set; }
    }
}
#pragma warning restore 1591