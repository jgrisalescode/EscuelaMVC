#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e946869e6ae95538df68132b63c9944b8db35bf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e946869e6ae95538df68132b63c9944b8db35bf0", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8b064d671447da0928a03045cfcd72ec0a7445", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
  
    // Se usa Model. por convención
    ViewData["Title"] = "Información Escuela";
    // Plantillas
    // Layout = "_Layout"; // Por defecto
    Layout = "Simple"; // Propia

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h1>Escuela ");
#nullable restore
#line 15 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2>Nombre: ");
#nullable restore
#line 16 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>Tipo de Escuela: ");
#nullable restore
#line 17 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                            Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <address>\r\n                <p>Dirección: ");
#nullable restore
#line 19 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                         Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Dirección: ");
#nullable restore
#line 20 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                         Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Dirección: ");
#nullable restore
#line 21 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                         Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </address>\r\n            <p><strong>Año de fundación: ");
#nullable restore
#line 23 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
                                    Write(Model.AñoDeCreación);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <p>");
#nullable restore
#line 24 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
          Write(ViewBag.CualquierCosa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 25 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Escuela\Index.cshtml"
          Write(ViewData["CualquierCosa"]);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
