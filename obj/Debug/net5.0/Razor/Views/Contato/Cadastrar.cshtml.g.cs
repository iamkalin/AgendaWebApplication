#pragma checksum "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5973574a576e7dc4cbd4bfdd408296a2b6356ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Cadastrar), @"mvc.1.0.view", @"/Views/Contato/Cadastrar.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kalin\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kalin\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5973574a576e7dc4cbd4bfdd408296a2b6356ed9", @"/Views/Contato/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Contato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/adicionarEmodificar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/contato/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5973574a576e7dc4cbd4bfdd408296a2b6356ed95321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"adicionarEmodificar col-12  col-lg-8 mx-auto \">\r\n            <h1 class=\"text-center text-funcao\">CADASTRAR</h1>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5973574a576e7dc4cbd4bfdd408296a2b6356ed96762", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"nome\">Nome</label>\r\n                    <input type=\"text\" name=\"nome\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 582, "\"", 601, 1);
#nullable restore
#line 15 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
WriteAttributeValue("", 590, Model.Nome, 590, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"nome\" placeholder=\"Digite o nome\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
               Write(Html.ValidationMessage("nome"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Telefone\">Telefone</label>\r\n                    <input type=\"text\" name=\"telefone\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 897, "\"", 921, 1);
#nullable restore
#line 20 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
WriteAttributeValue(" ", 905, Model.Telefone, 906, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Telefone\" placeholder=\"Digite o Telefone\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
               Write(Html.ValidationMessage("telefone"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"Email\">Email</label>\r\n                    <input type=\"text\" name=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1220, "\"", 1241, 1);
#nullable restore
#line 25 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
WriteAttributeValue(" ", 1228, Model.Email, 1229, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Email\" placeholder=\"Digite o Email\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\kalin\source\repos\WebApplication1\Views\Contato\Cadastrar.cshtml"
               Write(Html.ValidationMessage("email"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"row\">\r\n                    <button type=\"submit\" class=\" col-6 btn btn-primary\">Salvar</button> <a href=\"/contato/\" class=\"col-6 btn btn-primary\"> Voltar</a>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Contato> Html { get; private set; }
    }
}
#pragma warning restore 1591
