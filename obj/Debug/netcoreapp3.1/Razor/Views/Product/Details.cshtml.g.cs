#pragma checksum "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "167c490e820a44fcc64a528ffcc8052cfb5a8148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\_ViewImports.cshtml"
using ShoppingApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\_ViewImports.cshtml"
using ShoppingApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\_ViewImports.cshtml"
using ShoppingApp.WebUI.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"167c490e820a44fcc64a528ffcc8052cfb5a8148", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd50a815f2ce23811f127a218876c9392d1889db", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Card", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""content"">

    <!-- shop section start -->
    <section id=""shop"" class=""container"">

        <!-- row start -->
        <div class=""row"">

            <!-- sidebar start -->
            <div id=""sidebar"" class=""col-md-3"">

                <!-- search widget start -->
                <div class=""widget"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "167c490e820a44fcc64a528ffcc8052cfb5a81486286", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <!-- search widget end -->\n                <!-- categories widget start -->\n                ");
#nullable restore
#line 27 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <!-- categories widget end -->\n                <!-- featured products widget start -->\n                ");
#nullable restore
#line 30 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- featured products widget end -->

            </div>
            <!-- sidebar end -->
            <!-- main column start -->
            <div class=""col-md-9"">

                <div class=""row"">


                    <!-- product page top info start -->
                    <div class=""col-md-12 product"">
                        <div class=""row"">
                            <div class=""col-md-6"">

                                <div id=""product-gallery"" class=""owl-carousel"">
");
#nullable restore
#line 47 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                     foreach (var img in Model.Product.Images)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "167c490e820a44fcc64a528ffcc8052cfb5a81489776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1927, "~/images/products/", 1927, 18, true);
#nullable restore
#line 50 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1945, img.ImageName, 1945, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n");
#nullable restore
#line 52 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </div>\n\n                            </div>\n\n                            <div class=\"col-md-6\">\n\n                                <div class=\"padding15\">\n                                    <h2 class=\"product-title\"><b>");
#nullable restore
#line 61 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                                            Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h2>
                                    <p>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        3 Reviews
                                    </p>
                                    <p class=""product-price"">$");
#nullable restore
#line 66 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                                         Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                                <p>");
#nullable restore
#line 68 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                              Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n\n                                <div class=\"padding15\">\n\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "167c490e820a44fcc64a528ffcc8052cfb5a814813438", async() => {
                WriteLiteral("\n                                        <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 3094, "\"", 3126, 1);
#nullable restore
#line 75 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
WriteAttributeValue("", 3102, Model.Product.ProductId, 3102, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                        
                                        <div class=""form-group qty"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon"">Qty</span>
                                                <input type=""number"" name=""quantity"" size=""4"" class=""form-control"" value=""1"" min=""1"" step=""1"">
                                            </div>
                                        </div>
                                        <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-cart-plus fa-fw""></i> Sepete Ekle</button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                </div>\n\n\n                                <p><b>Category:</b>\n");
#nullable restore
#line 90 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                 foreach (var item in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\">");
#nullable restore
#line 92 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>   \r\n");
#nullable restore
#line 93 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>

                            </div>
                        </div>
                    </div>
                    <!-- product page top info end -->
                    <!-- product page middle info start -->
                    <div class=""col-md-12 padding25"">


                        <ul class=""nav nav-tabs"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">Description</a></li>
                            <li><a data-toggle=""tab"" href=""#spec"">Specifications</a></li>
                            <li><a data-toggle=""tab"" href=""#reviews"">Reviews (3)</a></li>
                        </ul>


                        <div class=""tab-content"">

                            <!-- description tab start -->
                            <div id=""description"" class=""tab-pane fade in active"">
                                ");
#nullable restore
#line 115 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                           Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <!-- description tab end -->
                            <!-- Specifications tab start -->
                            <div id=""spec"" class=""tab-pane fade"">
                                <div class=""table-responsive"">
                                    <table class=""table table-striped table-hover"">
");
#nullable restore
#line 122 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                         foreach (var item in Model.ProductAttributes)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                                <td><b>");
#nullable restore
#line 125 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                                  Write(item.Attribute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n                                                <td>");
#nullable restore
#line 126 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            </tr>\n");
#nullable restore
#line 128 "C:\Users\melih\source\repos\ShoppingApp.WebUI\ShoppingApp.WebUI\Views\Product\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </table>
                                </div>
                            </div>
                            <!-- Specifications tab end -->
                            <!-- reviews tab start -->
                            <div id=""reviews"" class=""tab-pane fade"">

                                <div class=""reviews-list"">

                                    <div class=""media"">

                                        <a class=""media-left"" href=""#"">
                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 6405, "\"", 6411, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb8_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">John Doe <small>2 days ago</small></h4>
                                            At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
                                        </div>
                                    </div>

                                    <div class=""media"">

                                        ");
            WriteLiteral("<a class=\"media-left\" href=\"#\">\n                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 7516, "\"", 7522, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb5_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">Sarah Smith<small>4 days ago</small></h4>
                                            Nunc risus ex, tempus quis purus ac, tempor consequat ex. Vivamus sem magna, maximus at est id, maximus aliquet nunc. Suspendisse lacinia velit a eros porttitor, in interdum ante faucibus.
                                        </div>
                                    </div>

                                    <div class=""media"">

                                        <a class=""media-left"" href=""#"">
                                            <img");
            BeginWriteAttribute("alt", " alt=\"", 8522, "\"", 8528, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb3_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">Jane Doe<small>5 days ago</small></h4>
                                            Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.
                                        </div>
                                    </div>

                                </div>

                                <div class=""page-header"">
                                    <h4>ADD A <b>REVIEW</b></h4>
                                </div>

                                <p cla");
            WriteLiteral("ss=\"text-muted\">You must be logged in to add a review.</p>\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "167c490e820a44fcc64a528ffcc8052cfb5a814824901", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""form-group col-xs-6"">
                                            <input type=""text"" class=""form-control input-lg"" placeholder=""Name*"" required>
                                        </div>
                                        <div class=""form-group col-xs-6"">
                                            <input type=""email"" class=""form-control input-lg"" placeholder=""Email*"" required>
                                        </div>

                                        <div class=""form-group col-xs-12"">
                                            <textarea class=""form-control"" rows=""6"" placeholder=""Review*"" required></textarea>
                                        </div>

                                        <div class=""form-group col-xs-12 text-right"">
                                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-check fa-fw""></i> SUBMIT REVIEW</but");
                WriteLiteral("ton>\n                                        </div>\n                                    </div>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                            </div>
                            <!-- reviews tab end -->

                        </div>

                    </div>
                    <!-- product page middle info end -->
                </div>
                <!-- row end -->

            </div>
            <!-- main column end -->

        </div>
        <!-- row end -->

    </section>
    <!-- shop section end -->

</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
