#pragma checksum "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e02f547ff9d7121751b43f4ae492b0ff98e4784a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Account), @"mvc.1.0.view", @"/Views/Usuario/Account.cshtml")]
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
#line 1 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\_ViewImports.cshtml"
using Moraes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\_ViewImports.cshtml"
using Moraes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e02f547ff9d7121751b43f4ae492b0ff98e4784a", @"/Views/Usuario/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e9614ed99b4d2956bd5f1c448544226847122f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuarioModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto Não Encontrada"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Dados do seu Usuário</h2>\r\n\r\n<h3>Título</h3>\r\n\r\n<style>\r\n    .fundo {\r\n        background-color: #fafafa !important;\r\n        opacity: 1 !important;\r\n        border: none !important;\r\n        text-align: center !important;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e02f547ff9d7121751b43f4ae492b0ff98e4784a4142", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-bordered"">

    <thead>
        <tr>
            <th class=""text-center"">ID</th>
            <th class=""text-center"">PERFIL</th>
            <th class=""text-center"">EMPRESA</th>
            <th class=""text-center"">NOME</th>
            <th class=""text-center"">EMAIL</th>
            <th class=""text-center"">COR HEXA</th>
            <th class=""text-center"">FOTO</th>
            <th class=""text-center"">FOTO</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 34 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
          
            foreach (var item in (List<UsuarioModel>)ViewBag.ListaUsuarios2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 38 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.IdUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 39 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.IdPerfil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 40 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.IdLicenca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 41 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 42 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 43 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                       Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1369, "\"", 1399, 2);
            WriteAttributeValue("", 1375, "../FotoPerfil/", 1375, 14, true);
#nullable restore
#line 44 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
WriteAttributeValue("", 1389, item.Foto, 1389, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Foto Não Encontrada\" /></td>\r\n                    <td class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e02f547ff9d7121751b43f4ae492b0ff98e4784a9011", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1490, "~/FotoPerfil/", 1490, 13, true);
#nullable restore
#line 45 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
AddHtmlAttributeValue("", 1503, item.Foto, 1503, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <!--<img src=\"");
#nullable restore
#line 46 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                             Write(Url.Content(ViewBag.Tree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />-->\r\n                    <!--<img src=\"~/FotoPerfil/niltonfoto2.jpg\" asp-append-version=\"true\">\r\n                        <img src=\"~/FotoPerfil/");
#nullable restore
#line 48 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                          Write(item.Foto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />-->\r\n                    <!--<img src=\"../FotoPerfil/");
#nullable restore
#line 49 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                                           Write(Url.Content(@item.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />-->\r\n                    <!--<img src=\"");
#nullable restore
#line 50 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
                             Write(Url.Content(ViewBag.Tree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />-->\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Usuario\Account.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuarioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591