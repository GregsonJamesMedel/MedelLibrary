#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Shared/_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83fb0e48e253facaf1d40c80f446626ccc0a5c92"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83fb0e48e253facaf1d40c80f446626ccc0a5c92", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3505, true);
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
                        <i class=""nc-icon nc-palette""></i>
                        <span class=""d-lg-none"">Dashboard</span>
                    </a>
                </li>
                <li class=""dropdow");
            WriteLiteral(@"n nav-item"">
                    <a href=""#"" class=""dropdown-toggle nav-link"" data-toggle=""dropdown"">
                        <i class=""nc-icon nc-planet""></i>
                        <span class=""notification"">5</span>
                        <span class=""d-lg-none"">Notification</span>
                    </a>
                    <ul class=""dropdown-menu"">
                        <a class=""dropdown-item"" href=""#"">Notification 1</a>
                        <a class=""dropdown-item"" href=""#"">Notification 2</a>
                        <a class=""dropdown-item"" href=""#"">Notification 3</a>
                        <a class=""dropdown-item"" href=""#"">Notification 4</a>
                        <a class=""dropdown-item"" href=""#"">Another notification</a>
                    </ul>
                </li>
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">
                        <i class=""nc-icon nc-zoom-split""></i>
                        <span class=""d-lg-block"">&nbsp;Search</span>
      ");
            WriteLiteral(@"              </a>
                </li>
            </ul>
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#pablo"">
                        <span class=""no-icon"">Account</span>
                    </a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""navbarDropdownMenuLink""
                        data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <span class=""no-icon"">Dropdown</span>
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <a class=""dropdown-item"" href=""#"">Something</a>
                        <a class=""dropdown-item"" href=""#"">Something else here<");
            WriteLiteral(@"/a>
                        <div class=""divider""></div>
                        <a class=""dropdown-item"" href=""#"">Separated link</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#pablo"">
                        <span class=""no-icon"">Log out</span>
                    </a>
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
