#pragma checksum "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40677162703503c292c794d1c5accb7a5907b259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ContosoCrafts.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\mamao\Documents\GitHub\contoso-crafts\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
       
    Product selectProduct;
    string selectProductId;

    void SelectProduct(string productId)
    {
        selectProductId = productId;
        selectProduct = ProductService.GetProducts().First(x => x.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
