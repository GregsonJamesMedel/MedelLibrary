#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Account/Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fca5baf44aca9052715870f41a2fff16b9153c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Settings), @"mvc.1.0.view", @"/Views/Account/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Settings.cshtml", typeof(AspNetCore.Views_Account_Settings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fca5baf44aca9052715870f41a2fff16b9153c4", @"/Views/Account/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b4127985bc82b2c9fa8f0d3ae97d9a43459d9ab", @"/Views/Account/_ViewImports.cshtml")]
    public class Views_Account_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SettingsPersonalDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/medel/Documents/MedelLibrary/Views/Account/Settings.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Account Settings";

#line default
#line hidden
            BeginContext(109, 1247, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-5 col-sm-3"">
        <div class=""nav flex-column nav-tabs h-100"" id=""vert-tabs-tab"" role=""tablist"" aria-orientation=""vertical"">
            <a class=""nav-link active"" id=""vert-tabs-home-tab"" data-toggle=""pill"" href=""#vert-tabs-home"" role=""tab""
                aria-controls=""vert-tabs-home"" aria-selected=""true"">Personal Info</a>
            <a class=""nav-link"" id=""vert-tabs-profile-tab"" data-toggle=""pill"" href=""#vert-tabs-profile"" role=""tab""
                aria-controls=""vert-tabs-profile"" aria-selected=""false"">Profile Photo</a>
            <a class=""nav-link"" id=""vert-tabs-messages-tab"" data-toggle=""pill"" href=""#vert-tabs-messages"" role=""tab""
                aria-controls=""vert-tabs-messages"" aria-selected=""false"">Password</a>
            <a class=""nav-link"" id=""vert-tabs-settings-tab"" data-toggle=""pill"" href=""#vert-tabs-settings"" role=""tab""
                aria-controls=""vert-tabs-settings"" aria-selected=""false"">Email</a>
        </div>
    </div>
    <div class=""col-7");
            WriteLiteral(" col-sm-9\">\n        <div class=\"tab-content\" id=\"vert-tabs-tabContent\">\n            <div class=\"tab-pane text-left fade show active\" id=\"vert-tabs-home\" role=\"tabpanel\" aria-labelledby=\"vert-tabs-home-tab\">\n                ");
            EndContext();
            BeginContext(1356, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1fca5baf44aca9052715870f41a2fff16b9153c45283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 23 "/home/medel/Documents/MedelLibrary/Views/Account/Settings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.PersonalDetails;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1430, 1855, true);
            WriteLiteral(@"
            </div>
            <div class=""tab-pane fade"" id=""vert-tabs-profile"" role=""tabpanel"" aria-labelledby=""vert-tabs-profile-tab"">
                
            </div>
            <div class=""tab-pane fade"" id=""vert-tabs-messages"" role=""tabpanel"" aria-labelledby=""vert-tabs-messages-tab"">
                Morbi turpis dolor, vulputate vitae felis non, tincidunt congue mauris. Phasellus volutpat augue id mi
                placerat mollis. Vivamus faucibus eu massa eget condimentum. Fusce nec hendrerit sem, ac tristique
                nulla. Integer vestibulum orci odio. Cras nec augue ipsum. Suspendisse ut velit condimentum, mattis urna
                a, malesuada nunc. Curabitur eleifend facilisis velit finibus tristique. Nam vulputate, eros non luctus
                efficitur, ipsum odio volutpat massa, sit amet sollicitudin est libero sed ipsum. Nulla lacinia, ex
                vitae gravida fermentum, lectus ipsum gravida arcu, id fermentum metus arcu vel metus. Curabitur eget
                sem");
            WriteLiteral(@" eu risus tincidunt eleifend ac ornare magna.
            </div>
            <div class=""tab-pane fade"" id=""vert-tabs-settings"" role=""tabpanel"" aria-labelledby=""vert-tabs-settings-tab"">
                Pellentesque vestibulum commodo nibh nec blandit. Maecenas neque magna, iaculis tempus turpis ac, ornare
                sodales tellus. Mauris eget blandit dolor. Quisque tincidunt venenatis vulputate. Morbi euismod molestie
                tristique. Vestibulum consectetur dolor a vestibulum pharetra. Donec interdum placerat urna nec
                pharetra. Etiam eget dapibus orci, eget aliquet urna. Nunc at consequat diam. Nunc et felis ut nisl
                commodo dignissim. In hac habitasse platea dictumst. Praesent imperdiet accumsan ex sit amet facilisis.
            </div>
        </div>
    </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SettingsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
