#pragma checksum "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Empresas\AgregarEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcfc6235ccd023e92b8b56dd8bd31991c0d7ef59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Epets.App.Presentacion.Pages.Empresas.Pages_Empresas_AgregarEmpresa), @"mvc.1.0.razor-page", @"/Pages/Empresas/AgregarEmpresa.cshtml")]
namespace Epets.App.Presentacion.Pages.Empresas
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
#line 1 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\_ViewImports.cshtml"
using Epets.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcfc6235ccd023e92b8b56dd8bd31991c0d7ef59", @"/Pages/Empresas/AgregarEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d40880a7bf140c40cac66976ecbc90f9043f38fe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empresas_AgregarEmpresa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnRegistrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3 wow zoomIn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 20px; margin-left: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Empresas/AgregarEmpresa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Epets.App-main\Epets.App\Epets.App.Presentacion\Pages\Empresas\AgregarEmpresa.cshtml"
  
     ViewData["Title"] = "E-Pets-Empresa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    tr:hover {
        background-color: rgb(252, 255, 95);
    }

    #jhan {
        border-radius: 150%;
        height: 50px;
        width: 50px;
        font-size: 1px;

    }
    #BannerEmpresa{
        
        
        background-image: url(""../img/Banner_Veterinaria.jpg"");
    }

    #jhan:hover {
        border-radius: 0%;
        height: 50px;
        width: 100px;
        font-size: 30px;

    }

    #btnConsultar:hover{
        background-color: #BBBBBB;
    }

     #btnRegistrar:hover{
        background-color: #0DC7E5;
    }

    #btnActualizar:hover{
        background-color: #10D691;
    }

    #btnEliminar:hover{
        background-color: #FE5D6E;
    }


    #imagen {
        border-top-left-radius: 70%;
    }

    #Cardimagen:hover #imagen {
        border-top-left-radius: 0px;
    }
</style>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""text-center"">
                <h");
            WriteLiteral(@"1 class=""display-4"">Bienvenido a Agregar Nueva Empresa</h1>
                <p>MinTic-2021 <a href=""/Grupo_4/InicioGrupo_4"">Grupo_4</a>.</p>
            </div>

            <div id=""BannerEmpresa"" class=""page-banner overlay-dark bg-image"">
                <div class=""banner-section"">
                    <div class=""container text-center wow fadeInUp"">
                        <nav aria-label=""Breadcrumb"">
                            <ol class=""breadcrumb breadcrumb-dark bg-transparent justify-content-center py-0 mb-2"">
                                <li class=""breadcrumb-item""><a href=""/Index"">Inicio</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Empresa_ Agregar Empresa</li>
                            </ol>
                        </nav>
                        <h1 class=""font-weight-normal"">Agregar Empresa</h1>
                    </div> <!-- .container -->
                </div> <!-- .banner-section -->
            </div> <!-- .page-banner -");
            WriteLiteral(@"->



            
    <div class=""row"">
        <div class=""col-md-5 col-sm-12"">
            <div class=""page-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"" style=""text-align: center;"">
                            <label>
                                <h1 class=""text-center wow fadeInUp"">Datos Empresa</h1>
                            </label>
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcfc6235ccd023e92b8b56dd8bd31991c0d7ef598599", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            
                            <div class=""col-md-6 "">
                                <label>Nombre Empresa: </label>
                                <input id=NombreEmpresa type=""text"" class=""form-control"" placeholder=""Digite Nombre Empresa"" 
                                    style=""margin-bottom: 20px;"">
                            </div>
                            <div class=""col-md-6 "">
                                 <label>Nit Empresa: </label>
                                <input id=NitEmpresa type=""text"" class=""form-control"" placeholder=""Digite NitEmpresa"" 
                                    style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                        <div class=""row"" style=""margin-bottom: 20px;"">

                            
                            <div class=""col-md-6 "">
                                <label>Direccion Empresa: </label>
     ");
                WriteLiteral(@"                           <input id=DireccionEmpresa type=""text"" class=""form-control"" placeholder=""Digite DireccionEmpresa"" 
                                    style=""margin-bottom: 20px;"">
                            </div>
                        </div>
                       
                       

                        <div class=""row"">
                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcfc6235ccd023e92b8b56dd8bd31991c0d7ef5910336", async() => {
                    WriteLiteral("Registrar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                <button id=""btnEliminar"" type=""submit"" class=""btn btn-danger mt-3 wow zoomIn""
                                style=""margin-bottom: 20px; margin-left: 10px;"">Eliminar</button>
                            <button id=""btnLimpiar"" type=""submit"" class=""btn btn-info mt-3 wow zoomIn"" 
                            onclick=""Limpiar();"" style=""margin-bottom: 20px; margin-left: 10px;"">Limpiar</button>
                            <a class=""btn btn-info mt-3 wow zoomIn"" id=""btnAtras""
                             style=""margin-bottom: 20px; margin-left: 10px;"" href=""/Medicos/InicioMedico"" role=""button"">Atras</a>
                            
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n       \r\n    </div> <!-- .page-section -->\r\n\r\n</div> <!-- .page-section -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Epets.App.Presentacion.Pages.AgregarEmpresaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.AgregarEmpresaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Epets.App.Presentacion.Pages.AgregarEmpresaModel>)PageContext?.ViewData;
        public Epets.App.Presentacion.Pages.AgregarEmpresaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
