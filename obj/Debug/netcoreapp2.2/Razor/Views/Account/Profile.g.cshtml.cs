#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3ad982e954eb0f449408bdbfd4fa18cea15aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3ad982e954eb0f449408bdbfd4fa18cea15aa9", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedelLibrary.ViewModels.ProfileVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/lalisa.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 94, true);
            WriteLiteral("\n<div class=\"jumbotron p-4\">\n    <div class=\"row\">\n        <div class=\"col-md-2\">\n            ");
            EndContext();
            BeginContext(186, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db3ad982e954eb0f449408bdbfd4fa18cea15aa94102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 64, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-10\">\n            <h3>");
            EndContext();
            BeginContext(300, 15, false);
#line 12 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
           Write(Model.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(315, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(317, 16, false);
#line 12 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                            Write(Model.Middlename);

#line default
#line hidden
            EndContext();
            BeginContext(333, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(335, 14, false);
#line 12 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                              Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("</h3>\n            <p class=\"mb-0\">Address: ");
            EndContext();
            BeginContext(393, 13, false);
#line 13 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(406, 40, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\">Email: ");
            EndContext();
            BeginContext(447, 11, false);
#line 14 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(458, 49, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\">Contact Number: ");
            EndContext();
            BeginContext(508, 19, false);
#line 15 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                       Write(Model.ContactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(527, 41, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\">Gender: ");
            EndContext();
            BeginContext(569, 12, false);
#line 16 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                               Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\">Birthday: ");
            EndContext();
            BeginContext(625, 14, false);
#line 17 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                 Write(Model.Birthday);

#line default
#line hidden
            EndContext();
            BeginContext(639, 499, true);
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <h3 class=""text-center"">Checkout History</h3><hr>
        <table class=""table table-hover table-striped"">
            <thead>
                <th>Id</th>
                <th>Title</th>
                <th>Author/Director</th>
                <th>Type</th>
                <th>Checkout</th>
                <th>Checkin</th>
                <th>Library Card Id</th>

            </thead>
            <tbody>
");
            EndContext();
#line 37 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                 foreach (var checkout in Model.Checkouts)
                {

#line default
#line hidden
            BeginContext(1215, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1269, 11, false);
#line 40 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1315, 14, false);
#line 41 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1364, 25, false);
#line 42 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1424, 13, false);
#line 43 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1472, 51, false);
#line 44 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(String.Format("{0:MMMM d, yyyy}",checkout.Checkout));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1558, 50, false);
#line 45 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(String.Format("{0:MMMM d, yyyy}",checkout.Checkin));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1643, 22, false);
#line 46 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 48 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1715, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedelLibrary.ViewModels.ProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
