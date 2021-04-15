#pragma checksum "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a37f3dbdbfff7849ae0148c7f0a9df69a4471b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Books), @"mvc.1.0.view", @"/Views/Book/Books.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Books.cshtml", typeof(AspNetCore.Views_Book_Books))]
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
#line 1 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\_ViewImports.cshtml"
using MedelLibrary;

#line default
#line hidden
#line 2 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\_ViewImports.cshtml"
using MedelLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a37f3dbdbfff7849ae0148c7f0a9df69a4471b", @"/Views/Book/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3abbebb739d19fd0430c71235eebf13c8dd4aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedelLibrary.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
  
    ViewBag.Title = "Books";

#line default
#line hidden
            BeginContext(83, 308, true);
            WriteLiteral(@"
<div class=""col-md-12"">
    <table class=""table table-hover table-striped"">
        <thead>
            <th>Title</th>
            <th>Author</th>
            <th>Status</th>
            <th>Cost</th>
            <th>Condition</th>
            <th>Category</th>
        </thead>
        <tbody>
");
            EndContext();
#line 17 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
            BeginContext(448, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(495, 10, false);
#line 20 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                   Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(505, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(537, 11, false);
#line 21 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                   Write(book.Author);

#line default
#line hidden
            EndContext();
            BeginContext(548, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(580, 11, false);
#line 22 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                   Write(book.Status);

#line default
#line hidden
            EndContext();
            BeginContext(591, 33, true);
            WriteLiteral("</td>\r\n                    <td>P ");
            EndContext();
            BeginContext(625, 26, false);
#line 23 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                     Write(book.Cost.ToString("0.##"));

#line default
#line hidden
            EndContext();
            BeginContext(651, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(683, 14, false);
#line 24 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                   Write(book.Condition);

#line default
#line hidden
            EndContext();
            BeginContext(697, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(729, 18, false);
#line 25 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
                   Write(book.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(747, 32, true);
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\GregsonJamesMedel\Documents\MedelLibrary\Views\Book\Books.cshtml"
            }

#line default
#line hidden
            BeginContext(794, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedelLibrary.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
