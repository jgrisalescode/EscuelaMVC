#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9685d8e5c6e0f3c8ef5da0999a692da263eb05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAlumno), @"mvc.1.0.view", @"/Views/Alumno/MultiAlumno.cshtml")]
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
#line 1 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\_ViewImports.cshtml"
using EscuelaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\_ViewImports.cshtml"
using EscuelaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d9685d8e5c6e0f3c8ef5da0999a692da263eb05", @"/Views/Alumno/MultiAlumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8b064d671447da0928a03045cfcd72ec0a7445", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAlumno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
  
    // Se usa Model. por convención
    ViewData["Title"] = "Información Alumno";
    // Plantillas
    // Layout = "_Layout"; // Por defecto
    Layout = "Simple"; // Propia

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h1>");
#nullable restore
#line 15 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>      
            <h2>Desde la Vista Parcial</h2>
            <!--Si no le paso el modelo en model a partial, trabaja con el modelo 
                que tenga la vista general en este caso este Index-->
            <table class=""table table-dark table-hover"">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Id</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
                     foreach (var alumno in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 30 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
                           Write(alumno.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
                           Write(alumno.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <p>");
#nullable restore
#line 36 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Alumno\MultiAlumno.cshtml"
          Write(ViewBag.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
