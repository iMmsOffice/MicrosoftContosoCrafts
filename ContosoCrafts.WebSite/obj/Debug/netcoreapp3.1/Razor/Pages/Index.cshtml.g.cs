#pragma checksum "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7c80b65aa20c867f515c009859a41c81a22ac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.WebSite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.WebSite.Pages
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
#line 1 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\_ViewImports.cshtml"
using ContosoCrafts.WebSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7c80b65aa20c867f515c009859a41c81a22ac0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa11e68d0151211d8b40704a22e8c4f2f2022cc3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Contoso Crafts</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 13 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 413, "\"", 461, 4);
            WriteAttributeValue("", 421, "background-image:", 421, 17, true);
            WriteAttributeValue(" ", 438, "url(\'", 439, 6, true);
#nullable restore
#line 16 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
WriteAttributeValue("", 444, product.Image, 444, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 458, "\');", 458, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
