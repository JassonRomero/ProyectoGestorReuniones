#pragma checksum "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82684d13d8a2fb262359dca1782b7e64000dacd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarea_ModificarTareaView), @"mvc.1.0.view", @"/Views/Tarea/ModificarTareaView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82684d13d8a2fb262359dca1782b7e64000dacd8", @"/Views/Tarea/ModificarTareaView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"987adce823cd3fb67776dff44770fcf9d85b8ca2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarea_ModificarTareaView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/script.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/moduloAdministrador.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
  
    ViewData["Title"] = "ModificarTarea";

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
#line 22 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82684d13d8a2fb262359dca1782b7e64000dacd87047", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82684d13d8a2fb262359dca1782b7e64000dacd88242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82684d13d8a2fb262359dca1782b7e64000dacd89437", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82684d13d8a2fb262359dca1782b7e64000dacd810632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82684d13d8a2fb262359dca1782b7e64000dacd811828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<script>    \n    var numeroJS = 1;\n    let listaUsuariosTarea = [];\n</script>\n\n");
#nullable restore
#line 37 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
 if (ViewBag.TareaModificar != null)
{
    TareaModel temp2 = ViewBag.TareaModificar;

    string[] vectorIdUsuario = temp2.listaUsuarios.Split(',');


    int numero = 1;

    for (int i = 0; i < vectorIdUsuario.Length; i++)
    {

        string idListaUsuariosTareas = "idListaUsuariosTareas";
       
        idListaUsuariosTareas += numero;
        numero = numero + 1;
      

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input");
            BeginWriteAttribute("id", " id=\"", 1316, "\"", 1343, 1);
#nullable restore
#line 54 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 1321, idListaUsuariosTareas, 1321, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1344, "\"", 1373, 1);
#nullable restore
#line 54 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 1351, idListaUsuariosTareas, 1351, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1395, "\"", 1422, 1);
#nullable restore
#line 54 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 1403, vectorIdUsuario[i], 1403, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\n");
            WriteLiteral(@"        <script>
         
            var idListaUsuariosTareasJS = ""idListaUsuariosTareas"";
            idListaUsuariosTareasJS += numeroJS;
            numeroJS = numeroJS + 1     
                       
            listaUsuariosTarea.push(document.getElementById(idListaUsuariosTareasJS).value);           
            sessionStorage.setItem(""ListaUsuariosTarea"", listaUsuariosTarea);
          

        </script>
");
#nullable restore
#line 67 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
  

    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<section id=""contenidoT"" style=""margin-top:120px;"">
    <section id=""principalT"">
        <center>
            <div class="" d-md-flex flex-md-equal w-100 my-md-3 pl-md-3"">
                <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""signup-form container-fluid"" style=""width:45%"">

                        <h2>Modificar Tarea</h2>
                        <p class=""hint-text"">Solo las jefaturas y el secretariado tiene el rango para crear Tareas.</p>
                        <center>
                            <div");
            BeginWriteAttribute("class", " class=\"", 2462, "\"", 2470, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:80%\">\n");
#nullable restore
#line 89 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                 if (ViewBag.TareaModificar != null)
                                {

                                    TareaModel temp = ViewBag.TareaModificar;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"form-group\">\n                                        <label for=\"NombreT\" class=\"sr-only\">Nombre de Tarea</label>\n                                        <input type=\"text\" id=\"NombreT\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2928, "\"", 2957, 1);
#nullable restore
#line 96 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 2936, temp.TC_Nombre_Tarea, 2936, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Nombre de Tarea\"");
            BeginWriteAttribute("required", " required=\"", 2988, "\"", 2999, 0);
            EndWriteAttribute();
            BeginWriteAttribute("autofocus", " autofocus=\"", 3000, "\"", 3012, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""descripcionT"">Descripción</label>
                                        <textarea class=""form-control"" id=""descripcionT"" rows=""3"">");
#nullable restore
#line 100 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                                                                             Write(temp.TC_Descripcion_Tarea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\n                                    </div>\n");
            WriteLiteral("                                    <input");
            BeginWriteAttribute("id", " id=\"", 3427, "\"", 3449, 1);
#nullable restore
#line 103 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 3432, temp.TN_Id_Tarea, 3432, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id_Tarea\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3487, "\"", 3512, 1);
#nullable restore
#line 103 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 3495, temp.TN_Id_Tarea, 3495, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
                                    <div class=""form-group""><button id=""btnUsuariosListaT"" type=""button"" class=""btn btn-secondary  btn-block"" data-toggle=""modal"" data-target=""#usuariosListaT"">Añadir contacto</button></div>
                                    <div class=""form-group""><button class=""btn btn-outline-secondary btn-block"" type=""button"" href=""javascript:;""");
            BeginWriteAttribute("onclick", " onclick=\"", 3892, "\"", 4018, 7);
            WriteAttributeValue("", 3902, "finalizarModificarTarea($(\'#", 3902, 28, true);
#nullable restore
#line 105 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 3930, temp.TN_Id_Tarea, 3930, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3947, "\').val(),", 3947, 9, true);
            WriteAttributeValue(" ", 3956, "$(\'#NombreT\').val(),", 3957, 21, true);
            WriteAttributeValue(" ", 3977, "$(\'#descripcionT\').val());", 3978, 27, true);
            WriteAttributeValue(" ", 4004, "return", 4005, 7, true);
            WriteAttributeValue(" ", 4011, "false;", 4012, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Finalizar</button></div>\n");
#nullable restore
#line 106 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <span id=""tareaDatos""></span>

                            </div>
                        </center>
                    </div>
                </div>
            </div>



        </center>

    </section>
</section>

<!-- Modal lista de usuario -->
<div class=""modal fade"" id=""usuariosListaT"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #343a40 !important;"">
                <h3 style=""color:#ffffff"">Lista de Usuarios</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                <table id=""tablaUsuariosCrearReunion"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
                    <thead c");
            WriteLiteral(@"lass=""thead-dark"">
                        <tr>
                            <th>Incluir</th>
                            <th>Nombre</th>
                            <th>Oficina</th>
                            <th>Puesto</th>
                        </tr>
                    </thead>
                    <tbody>


");
#nullable restore
#line 146 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                         if (ViewBag.ListaUsuarios != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                             if (ViewBag.TareaModificar != null)
                            {

                                TareaModel temp2 = ViewBag.TareaModificar;

                                foreach (UsuarioModel temp in ViewBag.ListaUsuarios)
                                {



                                    string[] vectorIdUsuario = temp2.listaUsuarios.Split(',');
                                    bool activo = false;
                                    for (int i = 0; i < vectorIdUsuario.Length; i++)
                                    {
                                        if (Int32.Parse(vectorIdUsuario[i].ToString()) == temp.IdUsuario)
                                        {
                                            activo = true;
                                            break;
                                        }
                                        else
                                        {
                                            activo = false;
                                        }

                                    }

                                    if (activo)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr>
                                            <td>
                                                <div class=""custom-control custom-switch"">
                                                    <input name=""checks"" type=""checkbox"" checked class=""custom-control-input""");
            BeginWriteAttribute("id", " id=\"", 6998, "\"", 7018, 1);
#nullable restore
#line 179 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 7003, temp.IdUsuario, 7003, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 7019, "\"", 7042, 1);
#nullable restore
#line 179 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 7027, temp.IdUsuario, 7027, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 7132, "\"", 7153, 1);
#nullable restore
#line 180 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 7138, temp.IdUsuario, 7138, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    </label>\n                                                </div>\n                                            </td>\n                                            <td>");
#nullable restore
#line 184 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 185 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Oficina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 186 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Puesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 188 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr>
                                            <td>
                                                <div class=""custom-control custom-switch"">
                                                    <input name=""checks"" type=""checkbox"" class=""custom-control-input""");
            BeginWriteAttribute("id", " id=\"", 7986, "\"", 8006, 1);
#nullable restore
#line 194 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 7991, temp.IdUsuario, 7991, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 8007, "\"", 8030, 1);
#nullable restore
#line 194 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 8015, temp.IdUsuario, 8015, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 8120, "\"", 8141, 1);
#nullable restore
#line 195 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
WriteAttributeValue("", 8126, temp.IdUsuario, 8126, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                    </label>\n                                                </div>\n                                            </td>\n                                            <td>");
#nullable restore
#line 199 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 200 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Oficina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 201 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                           Write(temp.Puesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 203 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "D:\Universidad\Analisis y diseño\ProyectoGestorReunionesCreadoPorLuis\ProyectoEntregaFinal\GestorReunionesAnalisis-luis\GestorReunionesProyectoAnalisis\Views\Tarea\ModificarTareaView.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>


            </div>

            <div class=""modal-footer"">
                <button type=""button"" href=""javascript:;"" onclick=""PruebaCerrar(); return false;"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                <input type=""button"" class=""btn btn-warning"" href=""javascript:;"" data-toggle=""modal"" data-target=""#modalAnadirContacto"" onclick=""anadirContactosTarea(); return false;"" value=""Agregar Contactos"" />
            </div>
        </div>
    </div>
</div>





<!--Modal Luego de añadir contacto-->
<div class=""modal fade"" id=""modalAnadirContacto"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #343a40 !important;"">
                <h3 style=""color:#ffffff""></h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" ");
            WriteLiteral(@"aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Los contactos fueron agregados con exito</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Aceptar</button>
            </div>
        </div>
    </div>
</div>




");
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
