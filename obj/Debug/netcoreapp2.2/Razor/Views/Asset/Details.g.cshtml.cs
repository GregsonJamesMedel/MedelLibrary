#pragma checksum "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68edafbb92990185261043a44d6f23a65095f7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asset_Details), @"mvc.1.0.view", @"/Views/Asset/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asset/Details.cshtml", typeof(AspNetCore.Views_Asset_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68edafbb92990185261043a44d6f23a65095f7a1", @"/Views/Asset/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Asset_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedelLibrary.ViewModels.AssetVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit@Model.Type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Asset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAsset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
  
    ViewBag.Title = Model.Title;
    if (Model.Type == "Book")
    {
        ViewBag.Controller = "Book";
        ViewBag.Action = "EditBook";
    }
    else
    {
        ViewBag.Controller = "Video";
        ViewBag.Action = "EditVideo";
    }

#line default
#line hidden
            BeginContext(290, 54, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(344, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68edafbb92990185261043a44d6f23a65095f7a16009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/img/");
#line 18 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            WriteLiteral(Model.ImageUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
AddHtmlAttributeValue("", 382, Model.Title, 382, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 18 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
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
            BeginContext(443, 71, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-6\">\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(515, 11, false);
#line 21 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(526, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 22 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
          
            if (Model.Type == "Book")
            {

#line default
#line hidden
            BeginContext(595, 27, true);
            WriteLiteral("                <p>Author: ");
            EndContext();
            BeginContext(623, 22, false);
#line 25 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                      Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(645, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 26 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(695, 29, true);
            WriteLiteral("                <p>Director: ");
            EndContext();
            BeginContext(725, 22, false);
#line 29 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                        Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(747, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 30 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            }
        

#line default
#line hidden
            BeginContext(776, 17, true);
            WriteLiteral("        <p>Year: ");
            EndContext();
            BeginContext(794, 10, false);
#line 32 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(804, 24, true);
            WriteLiteral("</p>\n        <p>Copies: ");
            EndContext();
            BeginContext(829, 20, false);
#line 33 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
              Write(Model.NumberOfCopies);

#line default
#line hidden
            EndContext();
            BeginContext(849, 22, true);
            WriteLiteral("</p>\n        <p>Cost: ");
            EndContext();
            BeginContext(872, 27, false);
#line 34 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            Write(Model.Cost.ToString("0.##"));

#line default
#line hidden
            EndContext();
            BeginContext(899, 26, true);
            WriteLiteral("</p>\n        <p>Location: ");
            EndContext();
            BeginContext(926, 11, false);
#line 35 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                Write(Model.Shelf);

#line default
#line hidden
            EndContext();
            BeginContext(937, 27, true);
            WriteLiteral("</p>\n        <p>Condition: ");
            EndContext();
            BeginContext(965, 15, false);
#line 36 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                 Write(Model.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(980, 24, true);
            WriteLiteral("</p>\n        <p>Status: ");
            EndContext();
            BeginContext(1005, 12, false);
#line 37 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
              Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 22, true);
            WriteLiteral("</p>\n        <p>Type: ");
            EndContext();
            BeginContext(1040, 10, false);
#line 38 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
            Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 26, true);
            WriteLiteral("</p>\n        <p>Category: ");
            EndContext();
            BeginContext(1077, 19, false);
#line 39 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 355, true);
            WriteLiteral(@"</p>

        <div class=""row"">

            <div class=""col-md-3"">
                <button class=""btn btn-primary btn-block mb-1"">Check out</button>
            </div>


            <div class=""col-md-3"">
                <button class=""btn btn-primary btn-block mb-1"">Hold</button>
            </div>


            <div class=""col-md-3"">
                ");
            EndContext();
            BeginContext(1451, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68edafbb92990185261043a44d6f23a65095f7a113655", async() => {
                BeginContext(1596, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 54 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                       WriteLiteral(Model.Type);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1604, 72, true);
            WriteLiteral("\n            </div>\n\n            <div class=\"col-md-3\">\n                ");
            EndContext();
            BeginContext(1676, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68edafbb92990185261043a44d6f23a65095f7a116735", async() => {
                BeginContext(1769, 114, true);
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-primary btn-block mb-1\">Delete</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "/home/medel/Documents/MedelLibrary/Views/Asset/Details.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1890, 52, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div></div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedelLibrary.ViewModels.AssetVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
