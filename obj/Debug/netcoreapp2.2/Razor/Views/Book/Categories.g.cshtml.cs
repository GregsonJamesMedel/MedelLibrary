#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77fa1654651fceb06010974ded63cff9229c861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Categories), @"mvc.1.0.view", @"/Views/Book/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Categories.cshtml", typeof(AspNetCore.Views_Book_Categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77fa1654651fceb06010974ded63cff9229c861", @"/Views/Book/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedelLibrary.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml"
  
    ViewBag.Title = "Categories";

#line default
#line hidden
            BeginContext(89, 173, true);
            WriteLiteral("\n<h1>Categories</h1>\n<table class=\"table table-hover table-striped\">\n    <thead>\n        <th>ID</th>\n        <th>Name</th>\n        <th>Actions</th>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 15 "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
            BeginContext(313, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(343, 11, false);
#line 18 "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml"
           Write(category.id);

#line default
#line hidden
            EndContext();
            BeginContext(354, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(377, 13, false);
#line 19 "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml"
           Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(390, 49, true);
            WriteLiteral("</td>\n            <td>$36,738</td>\n        </tr>\n");
            EndContext();
#line 22 "/home/medel/Documents/MedelLibrary/Views/Book/Categories.cshtml"
        }

#line default
#line hidden
            BeginContext(449, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedelLibrary.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
