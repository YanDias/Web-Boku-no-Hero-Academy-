#pragma checksum "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89ad85d87c9d2a9fa50ceb7aa9c1c543eefd01a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imc_Index), @"mvc.1.0.view", @"/Views/Imc/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imc/Index.cshtml", typeof(AspNetCore.Views_Imc_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89ad85d87c9d2a9fa50ceb7aa9c1c543eefd01a", @"/Views/Imc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3337a21e0e2b86cbd4b516f94de48624622a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Imc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IMCAlunos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "drpAlunos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(30, 55, true);
            WriteLiteral("<center><h2>Avaliação Aluno</h2></center>\n<br /><br />\n");
            EndContext();
            BeginContext(85, 515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd976329e77c49c6aaf55533f0e88c6f", async() => {
                BeginContext(160, 107, true);
                WriteLiteral("\n    <fieldset>\n        <div class=\"form-group\" id=\"Alunos\">\n            <label>Alunos</label>\n            ");
                EndContext();
                BeginContext(267, 187, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f4b81b3d4c94a88812c6ea7325a9442", async() => {
                    BeginContext(381, 17, true);
                    WriteLiteral("\n                ");
                    EndContext();
                    BeginContext(398, 34, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05a23a6812742b8b6dc813e9fa9031e", async() => {
                        BeginContext(406, 17, true);
                        WriteLiteral(" -- SELECIONE -- ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(432, 13, true);
                    WriteLiteral("\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 13 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Alunos;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(454, 139, true);
                WriteLiteral("\n        </div>\n        <input type=\"submit\"\n               class=\"btn btn-success\"\n               value=\"Buscar Aluno\" />\n    </fieldset>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(600, 21, true);
            WriteLiteral("\n\n<h2>IMC ALUNO</h2>\n");
            EndContext();
#line 26 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
 if (ViewBag.Validar == 1)
{

#line default
#line hidden
            BeginContext(650, 339, true);
            WriteLiteral(@"    <table class=""table table-hover table-striped""
           style=""margin-top:15px;margin-bottom:15px"">
        <thead>
            <tr>
                <th>Peso</th>
                <th>Altura</th>
                <th>Imc</th>
                <th>Data/Horario</th>
                

            </tr>
        </thead>

        <tbody>

");
            EndContext();
#line 43 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
             foreach (IMCAlunos item in Model)
            {

#line default
#line hidden
            BeginContext(1050, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1096, 9, false);
#line 46 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
                   Write(item.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1136, 11, false);
#line 47 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
                   Write(item.Altura);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1178, 12, false);
#line 48 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
                   Write(item.CalcImc);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1221, 13, false);
#line 49 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
                   Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 51, true);
            WriteLiteral("</td>\n\n\n                    \n                </tr>\n");
            EndContext();
#line 54 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1299, 30, true);
            WriteLiteral("        </tbody>\n    </table>\n");
            EndContext();
#line 57 "C:\Users\yanrd\OneDrive\Área de Trabalho\Faculdade 2019\WebAcademy-master\AcademyWeb\Views\Imc\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1331, 8, true);
            WriteLiteral("<center>");
            EndContext();
            BeginContext(1339, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14d4060114ee453cbf981bf012ff292d", async() => {
                BeginContext(1386, 19, true);
                WriteLiteral("Cadastrar Imc Aluno");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1409, 10, true);
            WriteLiteral("</center>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IMCAlunos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
