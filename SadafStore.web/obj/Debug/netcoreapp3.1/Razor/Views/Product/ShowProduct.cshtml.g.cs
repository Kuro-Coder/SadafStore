#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e557ec0f65937db9d81ef4b16265681407fde7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProduct), @"mvc.1.0.view", @"/Views/Product/ShowProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e557ec0f65937db9d81ef4b16265681407fde7", @"/Views/Product/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SadafStore.DataLayer.Entities.Product.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
  
    ViewData["Title"] = "مشاهده محصول";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""index.html"">خانه</a></li>
                        <li>مشاهده کالا (");
#nullable restore
#line 13 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                    Write(Model.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@") </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""product_page_bg"">
    <div class=""container"">
        <div class=""product_details_wrapper mb-55"">
            <!--product details start-->
            <div class=""product_details"">
                <div class=""row"">
                    <div class=""col-lg-5 col-md-6"">
                        <div class=""product-details-tab"">
                            <div id=""img-1"" class=""zoomWrapper single-zoom"">
                                <a href=""#"">
                                    <img id=""zoom1""");
            BeginWriteAttribute("src", " src=\"", 1064, "\"", 1108, 2);
            WriteAttributeValue("", 1070, "/ProductImg/images/", 1070, 19, true);
#nullable restore
#line 31 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 1089, Model.ProductImage, 1089, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-zoom-image=\"\"");
            BeginWriteAttribute("alt", " alt=\"", 1128, "\"", 1134, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-7 col-md-6"">
                        <div class=""product_d_right"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e557ec0f65937db9d81ef4b16265681407fde75578", async() => {
                WriteLiteral("\r\n\r\n                                <h3><a href=\"#\">");
#nullable restore
#line 41 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                           Write(Model.ProductTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></h3>\r\n\r\n                                <div class=\"price_box\">\r\n");
                WriteLiteral("                                    <span class=\"current_price\">");
#nullable restore
#line 45 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                                           Write(Model.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" تومان</span>\r\n                                </div>\r\n                                <div class=\"product_desc\">\r\n                                    <p>");
#nullable restore
#line 48 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                  Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"product_variant quantity\">\r\n                                    <label>\r\n                                        تعداد موجود از کالا:\r\n");
#nullable restore
#line 53 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                         if (@Model.ProductNumber > 0)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                       Write(Model.ProductNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>عدد</span>\r\n                                            <br />\r\n                                            <a class=\"buyBtn\"");
                BeginWriteAttribute("href", " href=\"", 2483, "\"", 2526, 2);
                WriteAttributeValue("", 2490, "/Product/BuyProduct/", 2490, 20, true);
#nullable restore
#line 57 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 2510, Model.ProductId, 2510, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">افزودن به سبد</a>\r\n");
#nullable restore
#line 58 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button class=\"button\" type=\"submit\">ناموجود</button>\r\n");
#nullable restore
#line 62 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </label>\r\n\r\n                                </div>\r\n\r\n                            ");
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
            WriteLiteral(@"
                            <div class=""priduct_social"">
                                <ul>
                                    <li><a class=""facebook"" href=""#"" title=""facebook""><i class=""fa fa-facebook""></i> لایک</a></li>
                                    <li><a class=""twitter"" href=""#"" title=""twitter""><i class=""fa fa-twitter""></i> توییت</a></li>
                                    <li><a class=""pinterest"" href=""#"" title=""pinterest""><i class=""fa fa-pinterest""></i> ذخیره</a></li>
                                    <li><a class=""google-plus"" href=""#"" title=""google +""><i class=""fa fa-google-plus""></i> اشتراک گذاری</a></li>
                                    <li><a class=""linkedin"" href=""#"" title=""linkedin""><i class=""fa fa-linkedin""></i> لینکدین</a></li>
                                </ul>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <!--product details end-->
            <!--product in");
            WriteLiteral(@"fo start-->
            <div class=""product_d_info"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""product_d_inner"">
                            <div class=""product_info_button"">
                                <ul class=""nav"" role=""tablist"">
                                    <li>
                                        <a class=""active"" data-toggle=""tab"" href=""#info"" role=""tab"" aria-controls=""info"" aria-selected=""false"">درباره محصول</a>
                                    </li>
                                    <li>
                                        <a data-toggle=""tab"" href=""#sheet"" role=""tab"" aria-controls=""sheet"" aria-selected=""false"">ویژگی و برچسب محصول</a>
                                    </li>
                                    <li>
                                        <a data-toggle=""tab"" href=""#reviews"" role=""tab"" aria-controls=""reviews"" aria-selected=""false"">نقد و بررسی محصول</a>
                        ");
            WriteLiteral(@"            </li>
                                </ul>
                            </div>
                            <div class=""tab-content"">
                                <div class=""tab-pane fade show active"" id=""info"" role=""tabpanel"">
                                    <div class=""product_info_content"">
                                        <p>");
#nullable restore
#line 104 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""tab-pane fade"" id=""sheet"" role=""tabpanel"">
                                    <div class=""product_d_table"">
                                        <label>ویژگی‌ها:</label>
                                        <p>");
#nullable restore
#line 110 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                      Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 111 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                         if (Model.Tags != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"widget_list tag_cloud\">\r\n                                                <h3>برچسب‌های محصولات</h3>\r\n");
#nullable restore
#line 115 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                                 foreach (string tag in Model.Tags.Split('-', StringSplitOptions.RemoveEmptyEntries))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6264, "\"", 6291, 2);
            WriteAttributeValue("", 6271, "/Product?filter=", 6271, 16, true);
#nullable restore
#line 117 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
WriteAttributeValue("", 6287, tag, 6287, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 117 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                                                               Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 118 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n");
#nullable restore
#line 120 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""tab-pane fade"" id=""reviews"" role=""tabpanel"">
                                    <div class=""reviews_wrapper"">
                                        <h2>1 نقد و بررسی برای این محصول</h2>
                                        <div class=""reviews_comment_box"">
                                            <div class=""comment_thmb"">
                                                <img src=""img/blog/comment2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7002, "\"", 7008, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""comment_text"">
                                                <div class=""reviews_meta"">
                                                    <div class=""product_rating"">
                                                        <ul>
                                                            <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                            <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                            <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                            <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                            <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                          ");
            WriteLiteral(@"              </ul>
                                                    </div>
                                                    <p><strong>مدیر </strong>- 12 آذر 1398</p>
                                                </div>
                                                <p>لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است</p>
                                            </div>

                                        </div>
                                        <div class=""comment_title"">
                                            <h2>یک نقد و بررسی بنویسید </h2>
                                            <p>ایمیل شما منتشر نخواهد شد. فیلد های الزامی مشخص شده اند</p>
                                        </div>
                                        <div class=""product_rating mb-10"">
                                            <h3>امتیاز شما</h3>
                             ");
            WriteLiteral(@"               <ul>
                                                <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                                <li><a href=""#""><i class=""ion-android-star-outline""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""product_review_form"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8e557ec0f65937db9d81ef4b16265681407fde719616", async() => {
                WriteLiteral(@"
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <label for=""review_comment"">نقد و بررسی شما </label>
                                                        <textarea name=""comment"" id=""review_comment""></textarea>
                                                    </div>
                                                    <div class=""col-lg-6 col-md-6"">
                                                        <label for=""author"">نام</label>
                                                        <input id=""author"" type=""text"">

                                                    </div>
                                                    <div class=""col-lg-6 col-md-6"">
                                                        <label for=""email"">ایمیل </label>
                                                        <input id=""email"" type=""email"" dir=""ltr""");
                WriteLiteral(">\r\n                                                    </div>\r\n                                                </div>\r\n                                                <button type=\"submit\">ثبت</button>\r\n                                            ");
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
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--product info end-->
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.DataLayer.Entities.Product.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
