#pragma checksum "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc8c5618a79b5059ab52b40a731f6689f2b341f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
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
#line 1 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\_ViewImports.cshtml"
using Lulus.CustomerApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc8c5618a79b5059ab52b40a731f6689f2b341f", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef9c734a7b65165787890fdb3c0b7cf1ee2e046", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lulus.ViewModels.Order.CurrentCartRespond>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .cart {\r\n        margin-top: 10px;\r\n        margin-left: 20%;\r\n        margin-right: 20%;\r\n    }\r\n</style>\r\n<div class=\"cart\">\r\n    <p hidden>");
#nullable restore
#line 10 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
         Write(Model.Order_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>Checkout</h2>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
  Write(Model.DetailCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" products</p>\r\n");
#nullable restore
#line 13 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
      double count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
     foreach (var item in Model.OrderDetails)
    {
        count += item.Product_SellPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    <h4>");
#nullable restore
#line 20 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                   Write(item.Product_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                  Write(item.Product_SellPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n                    <p>Size ");
#nullable restore
#line 22 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                       Write(item.SizeKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>\r\n                        Quantity: ");
#nullable restore
#line 24 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                             Write(item.OrderDetail_Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 868, "\"", 893, 1);
#nullable restore
#line 29 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 874, item.Product_Image, 874, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"100%\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n");
#nullable restore
#line 34 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <p>Total:</p>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <h3 style=\"text-align:right\">");
#nullable restore
#line 41 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                                        Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc8c5618a79b5059ab52b40a731f6689f2b341f8096", async() => {
                WriteLiteral("Confirm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Cart\Checkout.cshtml"
                                                                                          WriteLiteral(Model.Order_ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lulus.ViewModels.Order.CurrentCartRespond> Html { get; private set; }
    }
}
#pragma warning restore 1591
