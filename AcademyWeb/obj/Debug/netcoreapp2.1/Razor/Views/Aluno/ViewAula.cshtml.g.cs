#pragma checksum "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f71619ab3465e1d5fb1c2476b103fdea0492ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_ViewAula), @"mvc.1.0.view", @"/Views/Aluno/ViewAula.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aluno/ViewAula.cshtml", typeof(AspNetCore.Views_Aluno_ViewAula))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f71619ab3465e1d5fb1c2476b103fdea0492ab", @"/Views/Aluno/ViewAula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3337a21e0e2b86cbd4b516f94de48624622a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_ViewAula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aula>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlterarAula", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
  
    DateTime dataHora = ViewBag.DataHora;

#line default
#line hidden
            BeginContext(66, 454, true);
            WriteLiteral(@"


    <center>
        <h2>Todas as Aulas</h2>
    <br /><br />
        <table class=""table table-hover table-striped""
               style=""margin-top:15px;margin-bottom:15px"">
            <thead>
                <tr>
                    <th>Tipo</th>
                    <th>Local</th>
                    <th>Horaio</th>
                    <th>Vagas</th>
                    <th></th>

                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 25 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                 foreach (Aula item in Model)
                {

#line default
#line hidden
            BeginContext(584, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(638, 9, false);
#line 28 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                       Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(647, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(682, 10, false);
#line 29 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                       Write(item.Local);

#line default
#line hidden
            EndContext();
            BeginContext(692, 35, true);
            WriteLiteral("</td>\n\n                        <td>");
            EndContext();
            BeginContext(728, 9, false);
#line 31 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                       Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(737, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(772, 10, false);
#line 32 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                       Write(item.Vagas);

#line default
#line hidden
            EndContext();
            BeginContext(782, 7, true);
            WriteLiteral("</td>\n\n");
            EndContext();
#line 34 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                         if (item.Vagas > 0)
                        {

#line default
#line hidden
            BeginContext(860, 65, true);
            WriteLiteral("                            <td>\n                                ");
            EndContext();
            BeginContext(925, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14257b0c00a3463481416844c446e16b", async() => {
                BeginContext(1074, 83, true);
                WriteLiteral("\n                                    Reservar Vaga\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                                     WriteLiteral(item.IdAula);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1161, 35, true);
            WriteLiteral("\n                            </td>\n");
            EndContext();
#line 43 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1277, 84, true);
            WriteLiteral("                            <td><a class=\"btn btn-primary\"><b>Esgotado</b></a></td>\n");
            EndContext();
#line 47 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                        }

#line default
#line hidden
            BeginContext(1387, 26, true);
            WriteLiteral("                    </tr>\n");
            EndContext();
#line 49 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                }

#line default
#line hidden
            BeginContext(1431, 82, true);
            WriteLiteral("            </tbody>\n\n        </table>\n    </center><b>Dados atualizados em: </b> ");
            EndContext();
            BeginContext(1514, 8, false);
#line 53 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Aluno\ViewAula.cshtml"
                                      Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(1522, 1, true);
            WriteLiteral("\n");
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