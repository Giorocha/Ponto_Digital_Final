#pragma checksum "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dae5b53795cdf76534513c9c3cb5cb10db002fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae5b53795cdf76534513c9c3cb5cb10db002fb4", @"/Views/Shared/_HeaderNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc4b64e059740e28ad465bdd34434a84a42edf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt_logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
  
    var user = (string)ViewData["User"];
    var adm = (string)ViewData["Adm"];

#line default
#line hidden
            BeginContext(89, 120, true);
            WriteLiteral("\r\n<nav class=\"nav-bar\">\r\n     <div class=\"nav-container\">\r\n         <ul class=\"nav-list \" id=\"nav\">\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 209, "\'", 253, 2);
#line 9 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 216, Url.Action("Index","Home"), 216, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 243, "#principal", 243, 10, true);
            EndWriteAttribute();
            BeginContext(254, 40, true);
            WriteLiteral(">Principal</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 294, "\'", 338, 2);
#line 10 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 301, Url.Action("Index","Home"), 301, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 328, "#quemsomos", 328, 10, true);
            EndWriteAttribute();
            BeginContext(339, 42, true);
            WriteLiteral("> Quem Somos</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 381, "\'", 427, 2);
#line 11 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 388, Url.Action("Index","Home"), 388, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 415, "#localizaçao", 415, 12, true);
            EndWriteAttribute();
            BeginContext(428, 42, true);
            WriteLiteral(">Localização</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 470, "\'", 512, 2);
#line 12 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 477, Url.Action("Index","Home"), 477, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 504, "#pedidos", 504, 8, true);
            EndWriteAttribute();
            BeginContext(513, 39, true);
            WriteLiteral("> Pedidos</a></li>\r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 552, "\'", 594, 2);
#line 13 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 559, Url.Action("Index","Home"), 559, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 586, "#sacblog", 586, 8, true);
            EndWriteAttribute();
            BeginContext(595, 24, true);
            WriteLiteral("> Depoimentos</a></li>\r\n");
            EndContext();
#line 14 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
              if(string.IsNullOrEmpty(user) && string.IsNullOrEmpty(adm))
             {

#line default
#line hidden
            BeginContext(710, 21, true);
            WriteLiteral("                 <li>");
            EndContext();
            BeginContext(731, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6550defa60c741c5a63ef1946baf87fb", async() => {
                BeginContext(792, 5, true);
                WriteLiteral("Login");
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
            BeginContext(801, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
             }else{

#line default
#line hidden
            BeginContext(829, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 851, "\'", 891, 1);
#line 18 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 858, Url.Action("Index","Comentario"), 858, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(892, 45, true);
            WriteLiteral("> Comentários</a></li>\r\n                 <li>");
            EndContext();
            BeginContext(937, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9ce9354d8c4fdba902a5887e5ec57d", async() => {
                BeginContext(1000, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
             }

#line default
#line hidden
            BeginContext(1033, 34, true);
            WriteLiteral("             \r\n             <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1067, "\'", 1105, 1);
#line 22 "C:\Users\43706052881\Documents\Projeto_Final\Ponto_Digital_Final\Ponto_Digital\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 1074, Url.Action("Index","Cadastro"), 1074, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1106, 76, true);
            WriteLiteral(">Cadastro</a></li>\r\n\r\n             \r\n        </ul>\r\n    </div>\r\n</nav>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
