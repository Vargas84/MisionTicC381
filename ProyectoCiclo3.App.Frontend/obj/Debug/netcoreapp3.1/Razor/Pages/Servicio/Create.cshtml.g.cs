#pragma checksum "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd06e87dc22f87fafdb308612454a0e7dd8e2ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Servicio.Pages_Servicio_Create), @"mvc.1.0.razor-page", @"/Pages/Servicio/Create.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Servicio
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
#line 1 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abd06e87dc22f87fafdb308612454a0e7dd8e2ae", @"/Pages/Servicio/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Servicio_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<div class=\"text-center\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae3949", async() => {
                WriteLiteral("\r\n    <label for=\"origen\" class=\"form-label\">Origen:</label>\r\n    <select name=\"origen\" class=\"form-control\">\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae4334", async() => {
                    WriteLiteral("-");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
       foreach (var usuario in Model.Usuarios)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae5851", async() => {
#nullable restore
#line 13 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                               Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                                               Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                                                                    Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <label for=\"destino\" class=\"form-label\">Destino:</label>\r\n    <select name=\"destino\" class=\"form-control\">\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae8805", async() => {
                    WriteLiteral("-");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
       foreach (var usuario in Model.Usuarios)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae10322", async() => {
#nullable restore
#line 21 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                               Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                                               Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 21 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                                                                    Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </select>
 
    <label for=""fecha"" class=""form-label"">Fecha:</label>
    <input type=""date"" class=""form-control"" id=""fecha"" placeholder=""Fecha"" name=""fecha"" required>
 
    <label for=""hora"" class=""form-label"">Hora:</label>
    <input type=""time"" class=""form-control"" id=""hora"" placeholder=""Hora"" name=""hora"" required>
 
    <label for=""encomienda"" class=""form-label"">Encomienda:</label>
    <select name=""encomienda"" class=""form-control"" required>
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae13636", async() => {
                    WriteLiteral("-");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
       foreach (var encomienda in Model.Encomiendas)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abd06e87dc22f87fafdb308612454a0e7dd8e2ae15160", async() => {
#nullable restore
#line 36 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
                                  Write(encomienda.descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
           WriteLiteral(encomienda.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\DAILY VARGAS\OneDrive\Escritorio\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Create.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n \r\n    <hr>\r\n    <button type=\"submit\" class=\"btn btn-success\">Enviar</button>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.FormServicioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.FormServicioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.FormServicioModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.FormServicioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
