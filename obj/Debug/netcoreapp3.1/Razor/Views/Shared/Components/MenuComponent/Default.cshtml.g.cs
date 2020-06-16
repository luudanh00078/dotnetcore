#pragma checksum "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb0b315cce0e6e5d91e8551f8b9c28abb98bde9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MenuComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb0b315cce0e6e5d91e8551f8b9c28abb98bde9", @"/Views/Shared/Components/MenuComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4015925cdfa92bf9d0f35a912171e48f1325de6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<BookStore.Models.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"main-navigation flex-lg-right\">\n        <ul class=\"main-menu menu-right li-last-0\">\n");
#nullable restore
#line 4 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
             foreach (Menu menu in Model.Where(m => m.ParentId == null))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 268, "\"", 359, 2);
            WriteAttributeValue("", 276, "menu-item", 276, 9, true);
#nullable restore
#line 6 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
WriteAttributeValue(" ", 285, menu.ChildMenus != null && menu.ChildMenus.Count > 0?"has-children":"", 286, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <a href=\"javascript:void(0)\">\n                        ");
#nullable restore
#line 8 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                   Write(menu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n");
#nullable restore
#line 9 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                         if (menu.ChildMenus != null && menu.ChildMenus.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-chevron-down dropdown-arrow\"></i>\n");
#nullable restore
#line 12 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\n");
#nullable restore
#line 14 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                     if (menu.ChildMenus != null && menu.ChildMenus.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"sub-menu\">\n");
#nullable restore
#line 17 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                             foreach (Menu sub in menu.ChildMenus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li> <a href=\"#\">");
#nullable restore
#line 19 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                                            Write(sub.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 20 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n");
#nullable restore
#line 22 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\n");
#nullable restore
#line 24 "/Users/macbook/Projects/BookStore/BookStore/Views/Shared/Components/MenuComponent/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<BookStore.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
