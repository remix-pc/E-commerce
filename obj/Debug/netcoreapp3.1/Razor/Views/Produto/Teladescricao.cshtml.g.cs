#pragma checksum "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31142ee9ef1d0bbbf97ea7bd4ea1a88a83160585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Teladescricao), @"mvc.1.0.view", @"/Views/Produto/Teladescricao.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31142ee9ef1d0bbbf97ea7bd4ea1a88a83160585", @"/Views/Produto/Teladescricao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb27a62b9eb370388069b797c8e6dac4ef636ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Teladescricao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoJornada.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/produto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarAoCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/NovosProdutos.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("propaganda_produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
   

    if(Context.Session.GetString("admin") != null)
    {
        Layout = "_LayoutAdm";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
   


    Produto p = JsonConvert.DeserializeObject<Produto>(TempData["Produto"].ToString());

    Usuario c = null;

    if(Context.Session.GetString("cliente") != null)
    {
        Layout = "_Layout";
        c = JsonConvert.DeserializeObject<Usuario>(Context.Session.GetString("cliente"));
    } else
    {
        c = new Usuario(null, null, null, null, null, 0);
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n}\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31142ee9ef1d0bbbf97ea7bd4ea1a88a831605857754", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"mae_produto\">\r\n    <br><br>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31142ee9ef1d0bbbf97ea7bd4ea1a88a831605858928", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"conteiner_info_produto\">\r\n                <div class=\"img_info_produto\">\r\n");
#nullable restore
#line 44 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                       string formato = "data:image/jpeg;base64," + Convert.ToBase64String(p.ImgArquivo);

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <img");
                BeginWriteAttribute("src", " src=\"", 1077, "\"", 1091, 1);
#nullable restore
#line 45 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
WriteAttributeValue("", 1083, formato, 1083, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img_produto\">\r\n                </div>\r\n\r\n                <div class=\"text_info_produto\">\r\n                    <h1 class=\"titulo_produto\"> ");
#nullable restore
#line 49 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                                           Write(p.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                    <p class=\"valor_produto\">R$");
#nullable restore
#line 50 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                                          Write(p.Preco.ToString("#.#0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                    <p class=\"quantidade_estoque\">Quantidade no estoque: ");
#nullable restore
#line 51 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                                                                    Write(p.Quant);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p class=\"texto_quantidade_produto\"></p>\r\n\r\n                    <input type=\"number\" name=\"pQuantidade\" class=\"quantidade_produto\" min=\"1\"><br>\r\n                    <input hidden name=\"cpf\"");
                BeginWriteAttribute("value", " value=\"", 1627, "\"", 1641, 1);
#nullable restore
#line 55 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
WriteAttributeValue("", 1635, c.Cpf, 1635, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input hidden name=\"IDProduto\"");
                BeginWriteAttribute("value", " value=\"", 1697, "\"", 1710, 1);
#nullable restore
#line 56 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
WriteAttributeValue("", 1705, p.Id, 1705, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input hidden name=\"pNome\"");
                BeginWriteAttribute("value", " value=\"", 1762, "\"", 1777, 1);
#nullable restore
#line 57 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
WriteAttributeValue("", 1770, p.Nome, 1770, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input hidden name=\"pPreco\"");
                BeginWriteAttribute("value", " value=\"", 1830, "\"", 1846, 1);
#nullable restore
#line 58 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
WriteAttributeValue("", 1838, p.Preco, 1838, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n                    <button type=\"submit\" class=\"btn_adicionar_carrinho\">\r\n\r\n                        Adicionar ao carrinho\r\n\r\n                    </button>\r\n");
                WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <br /><br />

    <div class=""container_descrisao_produto"">
        <div class=""internal_descrisao_produto"">
            <div class=""conteudo_descrisao_produto"">
                <br>
                <h2 class=""titulo_conteudo_descrisao_produto"">Descrição do Produto</h2>
                <p class=""descr_produto""> ");
#nullable restore
#line 85 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                                     Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <br>\r\n                <br>\r\n                <p class=\"cod_prod\">Código do produto: ");
#nullable restore
#line 88 "C:\Users\aluno\source\repos\2dsb_grupod\ProjetoJornada\ProjetoJornada\Views\Produto\Teladescricao.cshtml"
                                                  Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <br>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31142ee9ef1d0bbbf97ea7bd4ea1a88a8316058516195", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoJornada.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
