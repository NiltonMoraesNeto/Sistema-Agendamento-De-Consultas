#pragma checksum "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399a9875847ab65f900e7f62a35538182a3a6639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399a9875847ab65f900e7f62a35538182a3a6639", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e9614ed99b4d2956bd5f1c448544226847122f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-BR\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399a9875847ab65f900e7f62a35538182a3a66395289", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <title>Moraes iT</title>

    <!-- Bootstrap CSS CDN -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css"" integrity=""sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4"" crossorigin=""anonymous"">
    <!-- Our Custom CSS -->
    <!--<link rel=""stylesheet"" href=""style.css"">-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "399a9875847ab65f900e7f62a35538182a3a66396100", async() => {
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
    <!-- Font Awesome JS -->
    <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/solid.js"" integrity=""sha384-tzzSw1/Vo+0N5UhStP3bvwWPq+uvzCMfrN1fEFe+xBmv1C/AtVX5K0uZtmcHitFZ"" crossorigin=""anonymous""></script>
    <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/fontawesome.js"" integrity=""sha384-6OIrr52G08NpOFSZdxxz1xdNSndlD4vdcf/q2myIUVO0VsqaGHJsB0RaBE01VTOY"" crossorigin=""anonymous""></script>


    <script type=""text/javascript"" src=""https://www.shieldui.com/shared/components/latest/js/jquery-1.11.1.min.js""></script>
    <script type=""text/javascript"" src=""https://www.shieldui.com/shared/components/latest/js/shieldui-all.min.js""></script>

    <!-- Adicionando Javascript BUSCA CEP -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.10/jquery.mask.js""></script>
    <!--<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.10/jquery.mask.min.js""></script>-->
    <!-- M??scara CNPJ CPF-->

    <script>

        $(documen");
                WriteLiteral(@"t).ready(function () {

            function limpa_formul??rio_cep() {
                // Limpa valores do formul??rio de cep.
                $(""#Rua"").val("""");
                $(""#Bairro"").val("""");
                $(""#Cidade"").val("""");
                $(""#Estado"").val("""");
            }

            //Quando o campo cep perde o foco.
            $(""#Cep"").blur(function () {

                //Nova vari??vel ""cep"" somente com d??gitos.
                var cep = $(this).val().replace(/\D/g, '');

                //Verifica se campo cep possui valor informado.
                if (cep != """") {

                    //Express??o regular para validar o CEP.
                    var validacep = /^[0-9]{8}$/;

                    //Valida o formato do CEP.
                    if (validacep.test(cep)) {

                        //Preenche os campos com ""..."" enquanto consulta webservice.
                        $(""#Rua"").val(""..."");
                        $(""#Bairro"").val(""..."");
              ");
                WriteLiteral(@"          $(""#Cidade"").val(""..."");
                        $(""#Estado"").val(""..."");

                        //Consulta o webservice viacep.com.br/
                        $.getJSON(""https://viacep.com.br/ws/"" + cep + ""/json/?callback=?"", function (dados) {

                            if (!(""erro"" in dados)) {
                                //Atualiza os campos com os valores da consulta.
                                $(""#Rua"").val(dados.logradouro);
                                $(""#Bairro"").val(dados.bairro);
                                $(""#Cidade"").val(dados.localidade);
                                $(""#Estado"").val(dados.uf);
                            } //end if.
                            else {
                                //CEP pesquisado n??o foi encontrado.
                                limpa_formul??rio_cep();
                                alert(""CEP n??o encontrado."");
                            }
                        });
                    } //end if.
 ");
                WriteLiteral(@"                   else {
                        //cep ?? inv??lido.
                        limpa_formul??rio_cep();
                        alert(""Formato de CEP inv??lido."");
                    }
                } //end if.
                else {
                    //cep sem valor, limpa formul??rio.
                    limpa_formul??rio_cep();
                }
            });
        });

    </script>

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399a9875847ab65f900e7f62a35538182a3a663911665", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Sidebar  -->
        <nav id=""sidebar"">
            <div class=""sidebar-header"">
                <h3>Moraes iT</h3>
            </div>

            <ul class=""list-unstyled components"">
                <p>Moraes iT</p>
                <li class=""active"">
                    <a href=""#homeSubmenu"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle""><i class=""fa fa-calendar"" aria-hidden=""true""></i> Calend??rio</a>
                    <ul class=""collapse list-unstyled"" id=""homeSubmenu"">
                        <li>
                            <a class=""linkMenu""");
                BeginWriteAttribute("href", " href=\"", 4809, "\"", 4849, 1);
#nullable restore
#line 109 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4816, Url.Action("Index","Calendario"), 4816, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-calendar\" aria-hidden=\"true\"></i> Home</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"linkMenu\"");
                BeginWriteAttribute("href", " href=\"", 5019, "\"", 5062, 1);
#nullable restore
#line 112 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5026, Url.Action("Cadastro","Calendario"), 5026, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-cog fa-spin fa-fw""></i> Novo Agendamento</a>
                        </li>
                    </ul>
                </li>
                <!--<li>
        <a href=""#"">Clientes</a>
    </li>-->
                <li>
                    <a href=""#Clientes"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle""><i class=""fa fa-child"" aria-hidden=""true""></i> Clientes</a>
                    <ul class=""collapse list-unstyled"" id=""Clientes"">
                        <li>
                            <a class=""linkMenu""");
                BeginWriteAttribute("href", " href=\"", 5621, "\"", 5661, 1);
#nullable restore
#line 123 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5628, Url.Action("Cadastro","Cliente"), 5628, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-plus\" aria-hidden=\"true\"></i> Cadastrar</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"linkMenu\"");
                BeginWriteAttribute("href", " href=\"", 5832, "\"", 5869, 1);
#nullable restore
#line 126 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5839, Url.Action("Index","Cliente"), 5839, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-list-ol"" aria-hidden=""true""></i> Listagem</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""#Usuario"" data-toggle=""collapse"" aria-expanded=""false"" class=""dropdown-toggle""><i class=""fa fa-user-circle"" aria-hidden=""true""></i> Usu??rios</a>
                    <ul class=""collapse list-unstyled"" id=""Usuario"">
                        <li>
                            <a class=""linkMenu""");
                BeginWriteAttribute("href", " href=\"", 6359, "\"", 6399, 1);
#nullable restore
#line 134 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6366, Url.Action("Cadastro","Usuario"), 6366, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-user-plus\" aria-hidden=\"true\"></i> Cadastrar</a>\r\n                        </li>\r\n                        <li>\r\n                            <a class=\"linkMenu\"");
                BeginWriteAttribute("href", " href=\"", 6575, "\"", 6612, 1);
#nullable restore
#line 137 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6582, Url.Action("Index","Usuario"), 6582, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-list-ol\" aria-hidden=\"true\"></i> Listagem</a>\r\n                        </li>\r\n                        <!--<li>\r\n                            <a class=\"linkMenu\" href=\"");
#nullable restore
#line 140 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
                                                 Write(Url.Action("Account","Usuario"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Dados do Seu Usu??rio</a>\r\n                        </li>-->\r\n                    </ul>\r\n                </li>\r\n                <li>\r\n                    <p>");
#nullable restore
#line 145 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
                  Write(UserAuth.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </li>
                <!--<li>
        <a href=""#"">Contact</a>
    </li>-->
            </ul>

            <!--<ul class=""list-unstyled CTAs"">
                <li>
                    <a href=""https://bootstrapious.com/tutorial/files/sidebar.zip"" class=""download"">Download source</a>
                </li>
                <li>
                    <a href=""https://bootstrapious.com/p/bootstrap-sidebar"" class=""article"">Back to article</a>
                </li>
            </ul>-->
        </nav>

        <!-- Page Content  -->
        <div id=""content"">

            <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                <div class=""container-fluid"">

                    <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info"">
                        <i class=""fas fa-align-left""></i>
                        <span>Expandir / Esconder</span>
                    </button>
                    <button class=""btn btn-dark d-inline-block d-lg-no");
                WriteLiteral(@"ne ml-auto"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <i class=""fas fa-align-justify""></i>
                    </button>

                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""nav navbar-nav ml-auto"">
                            <li class=""nav-item active"">
                                <a class=""nav-link"" href=""#""><p>");
#nullable restore
#line 179 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
                                                           Write(UserAuth.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 8731, "\"", 8770, 1);
#nullable restore
#line 182 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8738, Url.Action("Account","Usuario"), 8738, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Dados do Seu Usu??rio</a>
                            </li>
                            <!--<li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Page</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Page</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Page</a>
                            </li>-->
                        </ul>
                    </div>
                </div>
            </nav>
            <div class=""container"">
                <main role=""main"" class=""pb-3"">
                    ");
#nullable restore
#line 199 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </main>
            </div>

        </div>
    </div>


    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#sidebarCollapse').on('click', function () {
                $('#sidebar').toggleClass('active');
            });
        });
    </script>
    <script>
        $('.CpfCNPJ').mask('000.000.000-00', { reverse: true });
        $('.TelefoneFixo').mask('(00) 0000-0000');
        $('.TelefoneCelular').mask('(00) 00000-0000');
        //$('.DataNascimento').mask('00/00/0000');
    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399a9875847ab65f900e7f62a35538182a3a663921536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399a9875847ab65f900e7f62a35538182a3a663922636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "399a9875847ab65f900e7f62a35538182a3a663923736", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 223 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 224 "D:\Documentos\Udemy\SistemaNilton\Moraes\Moraes\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Moraes.Infra.IUser UserAuth { get; private set; }
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
