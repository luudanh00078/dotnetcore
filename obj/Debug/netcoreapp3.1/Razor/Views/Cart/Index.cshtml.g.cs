#pragma checksum "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a56a568779c74006c686c7f0b6a2f3394b35c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a56a568779c74006c686c7f0b6a2f3394b35c3", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4015925cdfa92bf9d0f35a912171e48f1325de6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Book, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Cart Page Start -->
<main class=""cart-page-main-block inner-page-sec-padding-bottom"">
    <div class=""cart_area cart-area-padding  "">
        <div class=""container"">
            <div class=""page-section-title"">
                <h1>Shopping Cart</h1>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a56a568779c74006c686c7f0b6a2f3394b35c34144", async() => {
                WriteLiteral(@"
                        <!-- Cart Table -->
                        <div class=""cart-table table-responsive mb--40"">
                            <table class=""table"">
                                <!-- Head Row -->
                                <thead>
                                    <tr>
                                        <th class=""pro-remove""></th>
                                        <th class=""pro-thumbnail"">Image</th>
                                        <th class=""pro-title"">Product</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 27 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
                                     foreach (KeyValuePair<Book, int> kv in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <!-- Product Row -->\n                                        <tr>\n                                            <td class=\"pro-remove\">\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 1641, "\"", 1693, 1);
#nullable restore
#line 32 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
WriteAttributeValue("", 1648, Url.Action("RemoveProduct", new {kv.Key.Id}), 1648, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"far fa-trash-alt\"></i></a>\n                                            </td>\n                                            <td class=\"pro-thumbnail\">\n                                                <a href=\"#\">\n");
                WriteLiteral("                                                </a>\n                                            </td>\n                                            <td class=\"pro-title\"><a href=\"#\">");
#nullable restore
#line 39 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
                                                                         Write(kv.Key.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\n                                            <td class=\"pro-price\"><span>$");
#nullable restore
#line 40 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
                                                                    Write(kv.Key.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></td>
                                            <td class=""pro-quantity"">
                                                <div class=""pro-qty"">
                                                    <div class=""count-input-block"">
                                                        <input type=""number""");
                BeginWriteAttribute("name", " name=\"", 2628, "\"", 2652, 3);
                WriteAttributeValue("", 2635, "books[", 2635, 6, true);
#nullable restore
#line 44 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
WriteAttributeValue("", 2641, kv.Key.Id, 2641, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2651, "]", 2651, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control text-center\"");
                BeginWriteAttribute("value", "\n                                                               value=\"", 2686, "\"", 2766, 1);
#nullable restore
#line 45 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
WriteAttributeValue("", 2757, kv.Value, 2757, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                                    </div>\n                                                </div>\n                                            </td>\n                                            <td class=\"pro-subtotal\"><span>$");
#nullable restore
#line 49 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
                                                                        Write(kv.Value * kv.Key.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\n                                        </tr>\n");
#nullable restore
#line 51 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                
                                    <tr>
                                        <td colspan=""6"" class=""actions"">
                                            <div class=""coupon-block"">
                                                <div class=""coupon-text"">
                                                    <label for=""coupon_code"">Coupon:</label>
                                                    <input type=""text"" name=""coupon_code"" class=""input-text""
                                                           id=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 3701, "\"", 3709, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"">
                                                </div>
                                                <div class=""coupon-btn"">
                                                    <input type=""submit"" class=""btn btn-outlined""
                                                           name=""apply_coupon"" value=""Apply coupon"">
                                                </div>
                                            </div>
                                            <div class=""update-block text-right"">
                                                <a");
                BeginWriteAttribute("href", " href=\"", 4303, "\"", 4332, 1);
#nullable restore
#line 67 "/Users/macbook/Projects/BookStore/BookStore/Views/Cart/Index.cshtml"
WriteAttributeValue("", 4310, ViewData["returnurl"], 4310, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-outlined"">Continue Shopping</a>
                                                <input type=""submit"" class=""btn btn-outlined"" name=""update_cart""
                                                       value=""Update cart"">
                                                <input type=""hidden"" id=""_wpnonce"" name=""_wpnonce""
                                                       value=""05741b501f"">
                                                <input type=""hidden""
                                                       name=""_wp_http_referer"" value=""/petmark/cart/"">
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-section-2"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-12 mb--30 mb-lg--0"">
                    <!-- slide Block 5 / Normal Slider -->
                    <div class=""cart-block-title"">
                        <h2>YOU MAY BE INTERESTED IN…</h2>
                    </div>
                    <div class=""product-slider sb-slick-slider"" data-slick-setting='{
							          ""autoplay"": true,
							          ""autoplaySpeed"": 8000,
							          ""slidesToShow"": 2
									  }' data-slick-responsive='[
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":575, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
            ]'>
  ");
            WriteLiteral(@"                      <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Lpple
                                    </span>
                                    <h3>
                                        <a href=""product-details.html"">
                                            Revolutionize Your BOOK With These
                                            Easy-peasy Tips
                                        </a>
                                    </h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7112, "\"", 7118, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <div class=\"hover-contents\">\n                                            <a href=\"product-details.html\" class=\"hover-image\">\n                                                <img src=\"image/products/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7373, "\"", 7379, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                                           ");
            WriteLiteral(@"         <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Jpple
                                    </span>
                                    <h3");
            WriteLiteral(@"><a href=""product-details.html"">Turn Your BOOK Into High Machine</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9746, "\"", 9752, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <div class=\"hover-contents\">\n                                            <a href=\"product-details.html\" class=\"hover-image\">\n                                                <img src=\"image/products/product-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 10007, "\"", 10013, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                                           ");
            WriteLiteral(@"         <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Wpple
                                    </span>
                                    <h3");
            WriteLiteral(@"><a href=""product-details.html"">3 Ways Create Better BOOK With</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12378, "\"", 12384, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <div class=\"hover-contents\">\n                                            <a href=\"product-details.html\" class=\"hover-image\">\n                                                <img src=\"image/products/product-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12639, "\"", 12645, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                                           ");
            WriteLiteral(@"         <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Epple
                                    </span>
                                    <h3");
            WriteLiteral(@">
                                        <a href=""product-details.html"">What You Can Learn From Bill Gates</a>
                                    </h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15092, "\"", 15098, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <div class=\"hover-contents\">\n                                            <a href=\"product-details.html\" class=\"hover-image\">\n                                                <img src=\"image/products/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 15353, "\"", 15359, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                                           ");
            WriteLiteral(@"         <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Hpple
                                    </span>
                                    <h3");
            WriteLiteral(@"><a href=""product-details.html"">Simple Things You To Save BOOK</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17724, "\"", 17730, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <div class=\"hover-contents\">\n                                            <a href=\"product-details.html\" class=\"hover-image\">\n                                                <img src=\"image/products/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 17985, "\"", 17991, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                                           ");
            WriteLiteral(@"         <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Cart Summary -->
                <div class=""col-lg-6 col-12 d-flex"">
                    <div class=""cart-summary"">
                        <div class=""cart-summary-wrap"">
                            <h4><span>Cart Summary</span></h4>
                            <p>Sub Total <span ");
            WriteLiteral(@"class=""text-primary"">$1250.00</span></p>
                            <p>Shipping Cost <span class=""text-primary"">$00.00</span></p>
                            <h2>Grand Total <span class=""text-primary"">$1250.00</span></h2>
                        </div>
                        <div class=""cart-summary-button"">
                            <a href=""checkout.html"" class=""checkout-btn c-btn btn--primary"">Checkout</a>
                            <button class=""update-btn c-btn btn-outlined"">Update Cart</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!-- Cart Page End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<Book, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
