#pragma checksum "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0db4776c9c71fd74148bb89ffcf0bd3b3cc0c15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryComponent/Default.cshtml")]
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
#nullable restore
#line 1 "/Users/macbook/Projects/BookStore/BookStore/Views/_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbook/Projects/BookStore/BookStore/Views/_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0db4776c9c71fd74148bb89ffcf0bd3b3cc0c15", @"/Views/Shared/Components/CategoryComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4015925cdfa92bf9d0f35a912171e48f1325de6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<BookStore.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"category-menu\">\n");
#nullable restore
#line 3 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
     foreach (Category category in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
         if(@category.ParentId != null) continue;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 198, "\"", 310, 2);
            WriteAttributeValue("", 206, "cat-item", 206, 8, true);
#nullable restore
#line 6 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
WriteAttributeValue(" ", 214, category.childCategories != null && category.childCategories.Count > 0 ? "has-children" : "", 215, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <a");
            BeginWriteAttribute("href", " href=\"", 323, "\"", 390, 1);
#nullable restore
#line 7 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
WriteAttributeValue("", 330, Url.Action("Category", "Book", new { catId = category.Id }), 330, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                                                                          Write(category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
              
                int count = category.Categorybook != null ? category.Categorybook.Count : 0;
                if (category.childCategories != null && category.childCategories.Count > 0)
                    foreach(Category cat in category.childCategories) {
                        count += cat.Categorybook != null ? cat.Categorybook.Count : 0;
                    }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            (");
#nullable restore
#line 15 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
        Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n        </a>\n");
#nullable restore
#line 17 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
             if (category.childCategories != null && category.childCategories.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\n");
#nullable restore
#line 20 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                     foreach (Category categoryItem in category.childCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"cat-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1112, "\"", 1183, 1);
#nullable restore
#line 22 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
WriteAttributeValue("", 1119, Url.Action("Category", "Book", new { catId = categoryItem.Id }), 1119, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                                                                                                                   Write(categoryItem.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            (");
#nullable restore
#line 23 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                              if (categoryItem.Categorybook != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                           Write(categoryItem.Categorybook.Count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                                                                
                            } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>0</span>\n");
#nullable restore
#line 28 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n                        </a></li>\n");
#nullable restore
#line 30 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n");
#nullable restore
#line 32 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </li>\n");
#nullable restore
#line 34 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/CategoryComponent/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<BookStore.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
