#pragma checksum "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8964c9cbd9beee293f4a3f5083f7d232d3bdf19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8964c9cbd9beee293f4a3f5083f7d232d3bdf19", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02e3e1f708194b12af526d02b17c9487e8f1a0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vaquinha.Domain.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doacoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-yellow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Vaquinha online";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3>Vaquinha online</h3>\r\n\r\n    <hr />\r\n\r\n    <p>        \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8964c9cbd9beee293f4a3f5083f7d232d3bdf194604", async() => {
                WriteLiteral("\r\n            <span></span>Doar agora\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ValorTotalArrecadado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ValorRestanteMeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.QuantidadeDoadores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <span>Tempo Restante</span>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Model.ValorTotalArrecadado.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Model.ValorRestanteMeta.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => Model.QuantidadeDoadores));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <code>  ");
#nullable restore
#line 50 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                       Write(Model.TempoRestanteDias);

#line default
#line hidden
#nullable disable
            WriteLiteral(" dias - ");
#nullable restore
#line 50 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                                       Write(Model.TempoRestanteHoras);

#line default
#line hidden
#nullable disable
            WriteLiteral(" horas - ");
#nullable restore
#line 50 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                                                                         Write(Model.TempoRestanteMinutos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutos</code>\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n\r\n");
#nullable restore
#line 57 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
     if (Model.Doadores.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n");
            WriteLiteral("        <h4>Quem já doou?</h4>\r\n");
            WriteLiteral("        <div id=\"carouselDoadores\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <div class=\"carousel-inner\" style=\"background-color: gray;\">\r\n");
#nullable restore
#line 65 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                 foreach (var item in Model.Doadores)
                {
                    var active = "";
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                     if (item==Model.Doadores.FirstOrDefault()) {active="active";}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2109, "\"", 2138, 2);
            WriteAttributeValue("", 2117, "carousel-item", 2117, 13, true);
#nullable restore
#line 69 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2130, active, 2131, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""row"">
                            <div class=""col-2""></div>
                            <div class=""col-8"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        ");
#nullable restore
#line 75 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 75 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                                Write(item.Valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"card-body\">\r\n                                        ");
#nullable restore
#line 78 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                   Write(item.MensagemApoio);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n                                        <i>");
#nullable restore
#line 79 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                      Write(item.DescricaoTempo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-2\"></div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 86 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev"" href=""#carouselDoadores"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Próximo</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselDoadores"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Anterior</span>
            </a>
        </div>
");
#nullable restore
#line 97 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n\r\n    <h4>Para onde vai minha doação? </h4>\r\n\r\n    <div id=\"carouselInstituicoes\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\" style=\"background-color: gray;\">\r\n");
#nullable restore
#line 105 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
             foreach (var item in Model.Instituicoes)
            {
                var active = "";
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                 if (item==Model.Instituicoes.FirstOrDefault()) {active="active";}

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 4009, "\"", 4038, 2);
            WriteAttributeValue("", 4017, "carousel-item", 4017, 13, true);
#nullable restore
#line 109 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4030, active, 4031, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""row"">
                        <div class=""col""></div>
                        <div class=""col"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    ");
#nullable restore
#line 115 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card-body\">\r\n                                    ");
#nullable restore
#line 118 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                               Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 118 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
                                              Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col\"></div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 125 "C:\Workspace\DIO\DIO_PRJ_Crowdfunding\src\Vaquinha.MVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselInstituicoes"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Próximo</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselInstituicoes"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Anterior</span>
        </a>
    </div>



</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(\'#cauroselDoadores\').carousel({\r\n            interval: 3000\r\n        });\r\n\r\n        $(\'#cauroselInstituicoes\').carousel({\r\n            interval: 2000\r\n        });\r\n        \r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vaquinha.Domain.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
