#pragma checksum "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ffa70cd84ed08169cefa2cec4ee4f08e61fc01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Comentarios), @"mvc.1.0.view", @"/Views/Administrador/Comentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Comentarios.cshtml", typeof(AspNetCore.Views_Administrador_Comentarios))]
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
#line 1 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\_ViewImports.cshtml"
using Ponto_Digital;

#line default
#line hidden
#line 2 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\_ViewImports.cshtml"
using Ponto_Digital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ffa70cd84ed08169cefa2cec4ee4f08e61fc01", @"/Views/Administrador/Comentarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc4b64e059740e28ad465bdd34434a84a42edf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Comentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ponto_Digital.ViewModel.ComentariosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
  
    var lista = ViewData["comentarios"] as List<Comentario>;
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(149, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b558a4478b284ba9bd0aca239e92f334", async() => {
                BeginContext(155, 202, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Comentários</title>\r\n    <link href=\"/css/style.css\" rel=\"stylesheet\" type=\"text/css\">\r\n    <link href=\"/css/style-login.css\" rel=\"stylesheet\" type=\"text/css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(364, 124, true);
            WriteLiteral("\r\n\r\n\r\n<nav class=\"nav-bar\">\r\n     <div class=\"nav-container\">\r\n         <ul class=\"nav-list \" id=\"nav\">\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 488, "\'", 531, 1);
#line 18 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 495, Url.Action("Index","Administrador"), 495, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 40, true);
            WriteLiteral(">Principal</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 572, "\'", 619, 1);
#line 19 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 579, Url.Action("Cadastros","Administrador"), 579, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(620, 40, true);
            WriteLiteral(">Cadastros</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 660, "\'", 709, 1);
#line 20 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 667, Url.Action("Comentarios","Administrador"), 667, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(710, 54, true);
            WriteLiteral("> Comentários</a></li>\r\n            \r\n            <li>");
            EndContext();
            BeginContext(764, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb01acc2ccb4c60904d598e7d038a49", async() => {
                BeginContext(827, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(837, 353, true);
            WriteLiteral(@"</li>
            
             
        </ul>
    </div>
</nav>

<main>

 <table class=""table"">
    <table class=""table table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th>ID</th>
                <th>Nome</th>
                <th>Comentario</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 41 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
             foreach (var item in Model.Comentarios)
            {

#line default
#line hidden
            BeginContext(1259, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1306, 7, false);
#line 44 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1345, 25, false);
#line 45 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
                   Write(item.usuario.NomeCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1402, 10, false);
#line 46 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
                   Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1444, 16, false);
#line 47 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
                   Write(item.DataCriacao);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 71, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <td><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1531, "\'", 1599, 3);
#line 49 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1538, Url.Action("AprovarComentario", "Administrador"), 1538, 49, false);

#line default
#line hidden
            WriteAttributeValue("", 1587, "?id=", 1587, 4, true);
#line 49 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1591, item.ID, 1591, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1600, 66, true);
            WriteLiteral(">Aprovar</a></button></td>\r\n                        <td><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1666, "\'", 1734, 3);
#line 50 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1673, Url.Action("AprovarComentario", "Administrador"), 1673, 49, false);

#line default
#line hidden
            WriteAttributeValue("", 1722, "?id=", 1722, 4, true);
#line 50 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1726, item.ID, 1726, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1735, 79, true);
            WriteLiteral(">Rejeitar</a></button></td>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 53 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Comentarios.cshtml"
            }

#line default
#line hidden
            BeginContext(1829, 56, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</table> \r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ponto_Digital.ViewModel.ComentariosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
