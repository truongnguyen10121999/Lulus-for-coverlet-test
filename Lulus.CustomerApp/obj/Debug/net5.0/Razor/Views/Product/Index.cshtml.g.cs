#pragma checksum "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae3924faa9f9b1f39231992dffc9d0a00ce6ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
using Lulus.CustomerApp.Models.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae3924faa9f9b1f39231992dffc9d0a00ce6ed2", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef9c734a7b65165787890fdb3c0b7cf1ee2e046", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lulus.CustomerApp.Models.Products.ProductCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FullList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:chocolate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .sort-bar {
        max-width: 300px;
        padding-left: 10%;
        padding-right: 10%;
        vertical-align: text-top
    }

        .sort-bar a {
            text-decoration: none;
            color: black;
        }

    .content {
        top: 0;
    }

    .content__textureimage {
        border-radius: 50px;
        cursor: pointer;
        margin-top: 10px;
        border-style: solid;
        border-color: gainsboro;
        border-width: 2px
    }

    .content__productimage {
        width: 100%
    }

    .mytable {
    }

        .mytable td {
            vertical-align: top;
            padding-top: 20px;
        }
    .content__price {
        font-size: large;
        padding-left: 10px
    }

    .content__more {
        margin-left: 45%;
        text-decoration: none;
        color: orange;
    }

        .content__more :hover {
            color: aqua;
            text-decoration: none
        }

    .thumbnail {
    ");
            WriteLiteral(@"    position: relative;
        cursor: pointer;
    }

    .thumbnail__image {
        opacity: 1;
        display: block;
        width: 100%;
        height: auto;
        transition: .5s ease;
        backface-visibility: hidden;
    }

    .thumbnail__content {
        transition: .5s ease;
        opacity: 0;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%);
        text-align: center;
    }

        .thumbnail__content a {
            text-decoration: none;
            color: dimgray;
            font-size: large
        }

    .thumbnail:hover .thumbnail__image {
        opacity: 0.3;
    }

    .thumbnail:hover .thumbnail__content {
        opacity: 1;
    }
</style>
<table style=""width: 100%"" class=""mytable"">
    <tr>
        <td>
            <div class=""sort-bar"">
                <h3>Refine By</h3>
                <br />
                <h4>Size</h4>
  ");
            WriteLiteral("              <hr />\r\n");
#nullable restore
#line 104 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 foreach (var size in Model.ListSizes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <span><input type=\"checkbox\" /></span>\r\n                        ");
#nullable restore
#line 108 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                   Write(size.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <br />\r\n");
#nullable restore
#line 111 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Price</h4>\r\n                ");
#nullable restore
#line 113 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
           Write(await Html.PartialAsync("Sort", new SortModel(ViewBag.CateID, ViewBag.SubcateID)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <hr />\r\n                <h4>Category</h4>\r\n");
#nullable restore
#line 116 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 foreach (var subCate in Model.ListSubCategories)
                {

                    if (subCate.Checked)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae3924faa9f9b1f39231992dffc9d0a00ce6ed28893", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 122 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                       Write(subCate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                            WriteLiteral(ViewBag.CateID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae3924faa9f9b1f39231992dffc9d0a00ce6ed212021", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 128 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                       Write(subCate.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                         WriteLiteral(ViewBag.CateID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                         WriteLiteral(subCate.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-key", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["key"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 132 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </td>\r\n        <td>\r\n            <div class=\"content\">\r\n");
#nullable restore
#line 137 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                 if (Model.ListProducts.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"text-align:center;width:600px\">Empty</p>\r\n");
#nullable restore
#line 140 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 145 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                             foreach (var product in Model.ListProducts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae3924faa9f9b1f39231992dffc9d0a00ce6ed217213", async() => {
                WriteLiteral("\r\n\r\n                                <div class=\"col-md-3\">\r\n");
#nullable restore
#line 150 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                     foreach (var line in product.ListProductLines)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                         foreach (var image in line.ListImages)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"thumbnail\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 4356, "\"", 4378, 1);
#nullable restore
#line 155 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 4362, image.Image_Url, 4362, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"content__productimage thumbnail__image\"");
                BeginWriteAttribute("id", " id=\"", 4426, "\"", 4455, 2);
                WriteAttributeValue("", 4431, "presentImage+", 4431, 13, true);
#nullable restore
#line 155 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 4444, product.ID, 4444, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                <div class=""thumbnail__content"">
                                                    <a>View more</a>
                                                </div>
                                            </div>
");
#nullable restore
#line 160 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                            break;
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                         
                                        break;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                      
                                        int lineCount = 0;
                                        foreach (var line in product.ListProductLines)
                                        {


                                            if (lineCount < 6)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <img");
                BeginWriteAttribute("src", " src=\"", 5301, "\"", 5330, 1);
#nullable restore
#line 172 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5307, line.Texture_Image_Url, 5307, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"line-image\" class=\"content__textureimage\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5378, "\"", 5442, 5);
                WriteAttributeValue("", 5388, "ChangeImage(", 5388, 12, true);
#nullable restore
#line 172 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5400, line.ListImages[0].Image_Url, 5400, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5429, ",", 5429, 1, true);
#nullable restore
#line 172 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 5430, product.ID, 5430, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5441, ")", 5441, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 173 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                lineCount++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <table>\r\n                                        <tr>\r\n                                            <td><p>");
#nullable restore
#line 183 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                              Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                                            <td>\r\n");
#nullable restore
#line 185 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                 if (product.SalePrice != product.Price)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <p class=\"content__price\"><span style=\"text-decoration:line-through;font-size:small\">$");
#nullable restore
#line 187 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                                                     Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> $");
#nullable restore
#line 187 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                                                                                                            Write(product.SalePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 188 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <p class=\"content__price\">$");
#nullable restore
#line 191 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                          Write(product.SalePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 192 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n                                    </table>\r\n                                </div>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                                                                               WriteLiteral(product.ID);

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
            WriteLiteral("\r\n");
#nullable restore
#line 200 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n\r\n                        <a href=\"#\" class=\"content__more\">View more ...</a>\r\n                    </div>\r\n");
#nullable restore
#line 206 "C:\Users\USER\Documents\GitHub\Lulus-for-coverlet-test\Lulus.CustomerApp\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </td>\r\n    </tr>\r\n</table>\r\n<script>\r\n    function ChangeImage(url, id) {\r\n        document.getElementById(\"presentImage\" + id).src = url;\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lulus.CustomerApp.Models.Products.ProductCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
