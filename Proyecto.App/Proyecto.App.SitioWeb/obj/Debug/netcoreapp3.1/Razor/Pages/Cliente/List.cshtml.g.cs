#pragma checksum "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4fcb3d213f98902b8026a2cbc6faa888ee9ec06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Proyecto.App.SitioWeb.Pages.Cliente.Pages_Cliente_List), @"mvc.1.0.razor-page", @"/Pages/Cliente/List.cshtml")]
namespace Proyecto.App.SitioWeb.Pages.Cliente
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
#line 1 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\_ViewImports.cshtml"
using Proyecto.App.SitioWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fcb3d213f98902b8026a2cbc6faa888ee9ec06", @"/Pages/Cliente/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c563d29b668fc260fa3a9f558450f58a468219", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cliente_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", ".\\Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h1>Listado de Clientes</h1>>
<table class=""table"">
    <thead>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Edad</th>
            <th>Genero</th>
            <th>Ciudad</th>
            <th>Pais</th>
            <th>Casos</th>

            <th>Borrar</th>
            <th>Editar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
         foreach (var cliente in Model.clientes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
           Write(cliente.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
           Write(cliente.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
           Write(cliente.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
           Write(cliente.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <!-- validar que el cliente tenga una ciudad y un pais asignado -->\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
             if(cliente.ciudad == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"color:blue\">No hay una ciudad asociada</td>\r\n");
#nullable restore
#line 35 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"

            }else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 38 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
               Write(cliente.ciudadId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 38 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                                   Write(cliente.ciudad.nombreCiudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
             if(cliente.pais== null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"color:blue\">No hay un pais asociado</td>\r\n");
#nullable restore
#line 44 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"

            }else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 47 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
               Write(cliente.paisId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 47 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                                 Write(cliente.pais.nombrePais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- Descripción del caso-->\r\n\r\n            <td>\r\n");
#nullable restore
#line 54 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                 foreach (var caso in cliente.casos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <p>CASO: ");
#nullable restore
#line 56 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                       Write(caso.fechaInicioCaso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 56 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                                               Write(caso.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n");
#nullable restore
#line 57 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fcb3d213f98902b8026a2cbc6faa888ee9ec0610783", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                                                                WriteLiteral(cliente.clienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fcb3d213f98902b8026a2cbc6faa888ee9ec0613128", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
                                                            WriteLiteral(cliente.clienteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Mary\Desktop\ProyectoCiclo3\Proyecto.App\Proyecto.App.SitioWeb\Pages\Cliente\List.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n<td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4fcb3d213f98902b8026a2cbc6faa888ee9ec0615725", async() => {
                WriteLiteral("Crear cliente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto.SitioWeb.App.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.SitioWeb.App.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.SitioWeb.App.Pages.ListModel>)PageContext?.ViewData;
        public Proyecto.SitioWeb.App.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
