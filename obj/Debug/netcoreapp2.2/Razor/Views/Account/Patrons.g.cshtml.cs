#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e00bfd47e545605f46a5ff4990ce8029df698d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Patrons), @"mvc.1.0.view", @"/Views/Account/Patrons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Patrons.cshtml", typeof(AspNetCore.Views_Account_Patrons))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e00bfd47e545605f46a5ff4990ce8029df698d", @"/Views/Account/Patrons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Patrons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedelLibrary.ViewModels.PatronsVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Patrons";

#line default
#line hidden
            BeginContext(136, 267, true);
            WriteLiteral(@"
<div class=""col-md-12"">
    <table class=""table table-hover table-striped"">
        <thead>
            <th>Id</th>
            <th>Email</th>
            <th>Firstname</th>
            <th>Lastname</th>
            <th>Address</th>
        </thead>
        <tbody>
");
            EndContext();
#line 17 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
             foreach (var patron in Model)
            {

#line default
#line hidden
            BeginContext(460, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(506, 24, false);
#line 20 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
                   Write(patron.Id.Substring(0,8));

#line default
#line hidden
            EndContext();
            BeginContext(530, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(561, 12, false);
#line 21 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
                   Write(patron.Email);

#line default
#line hidden
            EndContext();
            BeginContext(573, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(604, 34, false);
#line 22 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
                   Write(patron.PersonalDetailsVM.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(638, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(669, 33, false);
#line 23 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
                   Write(patron.PersonalDetailsVM.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(702, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(733, 32, false);
#line 24 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
                   Write(patron.PersonalDetailsVM.Address);

#line default
#line hidden
            EndContext();
            BeginContext(765, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 26 "/home/medel/Documents/MedelLibrary/Views/Account/Patrons.cshtml"
            }

#line default
#line hidden
            BeginContext(807, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedelLibrary.ViewModels.PatronsVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
