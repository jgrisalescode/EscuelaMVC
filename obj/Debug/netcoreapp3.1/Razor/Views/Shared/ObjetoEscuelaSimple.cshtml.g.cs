#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Shared\ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a11af498c24ec9fc2d965feec7d5345c5ae3eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a11af498c24ec9fc2d965feec7d5345c5ae3eca", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af8b064d671447da0928a03045cfcd72ec0a7445", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    Nombre: ");
#nullable restore
#line 4 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Id: ");
#nullable restore
#line 5 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Curso ASP .NET Core\EscuelaMVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
