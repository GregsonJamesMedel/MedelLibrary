#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Shared/_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936bc5371f810601064c7a243537739def381c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Navbar.cshtml", typeof(AspNetCore.Views_Shared__Navbar))]
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
#line 1 "/home/medel/Documents/MedelLibrary/Views/_ViewImports.cshtml"
using MedelLibrary;

#line default
#line hidden
#line 2 "/home/medel/Documents/MedelLibrary/Views/_ViewImports.cshtml"
using MedelLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936bc5371f810601064c7a243537739def381c3a", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1799, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg "" color-on-scroll=""500"">
    <div class=""container-fluid"">
        <a class=""navbar-brand"" href=""#pablo""> Dashboard </a>
        <button href="""" class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse""
            aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-bar burger-lines""></span>
            <span class=""navbar-toggler-bar burger-lines""></span>
            <span class=""navbar-toggler-bar burger-lines""></span>
        </button>
        <div class=""collapse navbar-collapse justify-content-end"" id=""navigation"">
            <ul class=""nav navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"" data-toggle=""dropdown"">
                        <span class=""d-lg-none"">Dashboard</span>
                    </a>
                </li>
            </ul>
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-");
            WriteLiteral(@"item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""navbarDropdownMenuLink""
                        data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <span class=""no-icon"">GregsonJamesMedel@Gmail.com</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                        <a class=""dropdown-item"" href=""#"">Profile</a>
                        <a class=""dropdown-item"" href=""#"">Settings</a>
                        <div class=""divider""></div>
                        <a class=""dropdown-item"" href=""#"">Sign out</a>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</nav>");
            EndContext();
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