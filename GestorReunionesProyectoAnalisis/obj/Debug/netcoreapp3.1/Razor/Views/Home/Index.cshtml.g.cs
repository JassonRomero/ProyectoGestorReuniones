#pragma checksum "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd5b455921cb15ad3fb50de54e2d5e6c127cc63e"
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
#line 1 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5b455921cb15ad3fb50de54e2d5e6c127cc63e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"987adce823cd3fb67776dff44770fcf9d85b8ca2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

    if (ViewBag.PermisoUsuario == "1")
    {
        Layout = "_Layout";
    }
    else if (ViewBag.PermisoUsuario == "2")
    {
        Layout = "LayoutUsuarioEstandar";
    }
    else if (ViewBag.PermisoUsuario == "3")
    {
        Layout = "LayoutUsuarioCatalogos";
    }

    if (ViewBag.PermisoUsuario == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\n            redireccion(\'/Usuario/MuestraLoginUsuario\');\n        </script>\n");
#nullable restore
#line 23 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
