#pragma checksum "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160c9d584b2d6c36274b7338bd1f32e5c1836483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Cadastros), @"mvc.1.0.view", @"/Views/Administrador/Cadastros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Cadastros.cshtml", typeof(AspNetCore.Views_Administrador_Cadastros))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160c9d584b2d6c36274b7338bd1f32e5c1836483", @"/Views/Administrador/Cadastros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc4b64e059740e28ad465bdd34434a84a42edf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Cadastros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ponto_Digital.ViewModel.ComentariosViewModel>
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
#line 2 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(87, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e75984ae844bd1aec029acd8c50407", async() => {
                BeginContext(93, 202, true);
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
            BeginContext(302, 122, true);
            WriteLiteral("\r\n\r\n<nav class=\"nav-bar\">\r\n     <div class=\"nav-container\">\r\n         <ul class=\"nav-list \" id=\"nav\">\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 424, "\'", 467, 1);
#line 16 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
WriteAttributeValue("", 431, Url.Action("Index","Administrador"), 431, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(468, 40, true);
            WriteLiteral(">Principal</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 508, "\'", 555, 1);
#line 17 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
WriteAttributeValue("", 515, Url.Action("Cadastros","Administrador"), 515, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(556, 40, true);
            WriteLiteral(">Cadastros</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 596, "\'", 645, 1);
#line 18 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
WriteAttributeValue("", 603, Url.Action("Comentarios","Administrador"), 603, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 54, true);
            WriteLiteral("> Comentários</a></li>\r\n            \r\n            <li>");
            EndContext();
            BeginContext(700, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d8a0d254ab4d4a942e0a844e671e39", async() => {
                BeginContext(763, 6, true);
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
            BeginContext(773, 420, true);
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
                <th>Email</th>
                <th>Senha</th>
                <th>Data Nascimento</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 40 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
             foreach (var item in Model.Usuarios)
            {

#line default
#line hidden
            BeginContext(1259, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1306, 7, false);
#line 43 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1345, 17, false);
#line 44 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
                   Write(item.NomeCompleto);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1394, 10, false);
#line 45 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1436, 10, false);
#line 46 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
                   Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1478, 19, false);
#line 47 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
                   Write(item.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Administrador\Cadastros.cshtml"
            }

#line default
#line hidden
            BeginContext(1542, 58, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</table> \r\n</main>\r\n\r\n\r\n");
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
