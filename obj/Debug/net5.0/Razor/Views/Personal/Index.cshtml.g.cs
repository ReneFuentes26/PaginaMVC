#pragma checksum "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da481cc96046cbf88ae485ca6c44f8aec393057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
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
#line 1 "C:\Users\SilenSent21\PaginaMVC\Views\_ViewImports.cshtml"
using PaginaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SilenSent21\PaginaMVC\Views\_ViewImports.cshtml"
using PaginaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da481cc96046cbf88ae485ca6c44f8aec393057", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528edfa62fa6f77126e278886e4bcfbc1aa35be1", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 > Pagina Personal</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.name, "Nombres"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 4 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                                 Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.lastname, "Apellidos"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 6 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                                       Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.age, "Edad"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                             Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.email, "Correo Electronico"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                                             Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.telefone, "Numero de Telefono"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                                                Write(Model.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.direction, "Direcion"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 14 "C:\Users\SilenSent21\PaginaMVC\Views\Personal\Index.cshtml"
                                       Write(Model.direction);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
