#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e2af8a3bf912463f3fa40b4072d8a8314f2b6a"
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
#line 1 "/home/medel/Documents/MedelLibrary/Views/Account/_ViewImports.cshtml"
using MedelLibrary.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e2af8a3bf912463f3fa40b4072d8a8314f2b6a", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4127985bc82b2c9fa8f0d3ae97d9a43459d9ab", @"/Views/Account/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/img/lalisa.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = @Model.Firstname + " " + Model.Lastname;

#line default
#line hidden
            BeginContext(129, 94, true);
            WriteLiteral("\n<div class=\"jumbotron p-4\">\n    <div class=\"row\">\n        <div class=\"col-md-2\">\n            ");
            EndContext();
            BeginContext(223, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5e2af8a3bf912463f3fa40b4072d8a8314f2b6a4528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 10 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(298, 85, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-10\">\n            <h3 class=\"text-primary\">");
            EndContext();
            BeginContext(384, 15, false);
#line 13 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                Write(Model.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(399, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(401, 16, false);
#line 13 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                 Write(Model.Middlename);

#line default
#line hidden
            EndContext();
            BeginContext(417, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(419, 14, false);
#line 13 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                   Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(433, 83, true);
            WriteLiteral("</h3>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Address:</span> ");
            EndContext();
            BeginContext(517, 13, false);
#line 14 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                        Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(530, 80, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Email:</span> ");
            EndContext();
            BeginContext(611, 11, false);
#line 15 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(622, 89, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Contact Number:</span> ");
            EndContext();
            BeginContext(712, 19, false);
#line 16 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                               Write(Model.ContactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(731, 81, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Gender:</span> ");
            EndContext();
            BeginContext(813, 12, false);
#line 17 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                       Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(825, 83, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Birthday:</span> ");
            EndContext();
            BeginContext(909, 48, false);
#line 18 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                         Write(String.Format("{0:MMMM d, yyyy}",Model.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(957, 87, true);
            WriteLiteral("</p>\n            <p class=\"mb-0\"><span style=\"font-weight: bold;\">Current Fees:</span> ");
            EndContext();
            BeginContext(1045, 17, false);
#line 19 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                                                                             Write(Model.CurrentFees);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 513, true);
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <h3 class=""text-center text-primary"">Checkout History</h3><hr>
        <table class=""table table-hover"" id=""dataTable"">
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
#line 39 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                 foreach (var checkout in Model.Checkouts)
                {

#line default
#line hidden
            BeginContext(1652, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1706, 11, false);
#line 42 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1752, 14, false);
#line 43 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1801, 25, false);
#line 44 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1826, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1861, 13, false);
#line 45 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1909, 51, false);
#line 46 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(String.Format("{0:MMMM d, yyyy}",checkout.Checkout));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1995, 50, false);
#line 47 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(String.Format("{0:MMMM d, yyyy}",checkout.Checkin));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(2080, 22, false);
#line 48 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                       Write(checkout.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(2102, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 50 "/home/medel/Documents/MedelLibrary/Views/Account/Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(2152, 56, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
