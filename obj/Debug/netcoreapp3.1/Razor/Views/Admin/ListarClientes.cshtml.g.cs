#pragma checksum "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c8907126db75d672bf26965e1832bd2cb8285b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListarClientes), @"mvc.1.0.view", @"/Views/Admin/ListarClientes.cshtml")]
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
#line 1 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\_ViewImports.cshtml"
using ProjetoJornada;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\_ViewImports.cshtml"
using ProjetoJornada.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c8907126db75d672bf26965e1832bd2cb8285b", @"/Views/Admin/ListarClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb27a62b9eb370388069b797c8e6dac4ef636ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListarClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoJornada.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/listarclientes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
 if (Context.Session.GetString("admin") != null)
{
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03c8907126db75d672bf26965e1832bd2cb8285b4459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <main class=""conteudo_cliente"">
        <br>
        <div id=""color_titulo_fundo"">
            <h2 class=""titulo_lista_clientes"">Lista de Clientes</h2>
        </div>

        <a href=""/Admin/PainelAdm""><button class=""botao_add_listagem"">Ir para Administra????o</button></a>

        <br>
        <br>
        <!-- Listagem dos Clientes -->
");
#nullable restore
#line 22 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"listaClientes\">\r\n                <ul>\r\n                    <li>Nome do Cliente: ");
#nullable restore
#line 26 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
                                    Write(cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Nome de Usu??rio: ");
#nullable restore
#line 27 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
                                    Write(cliente.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>E-Mail: ");
#nullable restore
#line 28 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
                           Write(cliente.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n");
            WriteLiteral("            <br />\r\n");
#nullable restore
#line 33 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </main>\r\n");
#nullable restore
#line 39 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"
}
else
{
    if (Context.Session.GetString("cliente") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Voce nao pode acessar essa p??gina</p>\r\n");
#nullable restore
#line 45 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Voce nao pode acessar essa p??gina</p>\r\n");
#nullable restore
#line 50 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Admin\ListarClientes.cshtml"

    }

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoJornada.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
