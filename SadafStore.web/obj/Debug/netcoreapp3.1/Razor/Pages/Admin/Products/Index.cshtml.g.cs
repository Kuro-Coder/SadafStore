#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76615ea2f716c438c0ba082835015c4b6e37ca29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Products_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76615ea2f716c438c0ba082835015c4b6e37ca29", @"/Pages/Admin/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Products_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card-box"">
            <div>
                <ol class=""linkinhead "">
                    <li><a href=""/"">خانه</a></li>
                    <li><a href=""/Admin"">داشبورد مدیریت</a></li>
                    <li class=""#"">لیست محصول‌ها</li>
                </ol>
            </div>
        </div>
    </div>
</div>


<div class=""row filter-row"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76615ea2f716c438c0ba082835015c4b6e37ca293327", async() => {
                WriteLiteral(@"
        <div class=""col-sm-3 col-xs-6"">
            <div class=""form-group form-focus select-focus focused"">
                <input type=""text"" class=""Myform-control form-control"" name=""filterUserName"" placeholder=""نام محصول"">
            </div>
        </div>
        <div class=""col-sm-3 col-xs-6"">
            <div class=""form-group form-focus select-focus focused"">
                <input type=""text"" class=""Myform-control form-control"" name=""filterEmail"" placeholder=""تگ محصول"">
            </div>
        </div>
        <div class=""col-sm-3 col-xs-6"">
            <button class=""btn btn-success btn-block""> جستجو </button>
        </div>
        <div class=""col-sm-3 col-xs-6"">
            <a href=""/Admin/Products"" class=""btn btn-warning btn-block""> خروج از حالت جستجو </a>
        </div>
    ");
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

<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""panel panel-table"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-md-5"">
                        <a href=""/admin/products/createproduct"">
                            <button type=""button"" class=""btn btn-success"">افزودن محصول جدید</button>
                        </a>
                        <a href=""/admin/users/DeleteProductList"">
                            <button type=""button"" class=""btn btn-danger"">لیست و بازگردانی محصول‌های حذف شده</button>
                        </a>
                    </div>

                    <div class=""col-md-7"">
                        <h2 class=""table-title"">لیست محصول‌ها</h2>
                    </div>
                </div>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-striped custom-table m-b-0"">
              ");
            WriteLiteral(@"          <thead>
                            <tr>
                                <th style=""min-width:200px;"">تصویر</th>
                                <th>نام</th>
                                <th>ارزش</th>
                                <th>تعداد</th>
                                <th>وضعیت</th>
                                <th class=""text-right"">اعمال</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 75 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                             foreach (var product in Model.ProductForProductListViewModel.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"min-width: 200px;\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3121, "\"", 3166, 2);
            WriteAttributeValue("", 3127, "/ProductImg/thumb/", 3127, 18, true);
#nullable restore
#line 79 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 3145, product.ProductImage, 3145, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"thumbnail\" />\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 81 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                   Write(product.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 82 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                   Write(product.ProductNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 85 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                         if (product.IsActive)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-white btn-sm rounded \"");
            BeginWriteAttribute("value", " value=\"", 3664, "\"", 3672, 0);
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\">\r\n                                                <i class=\"fa fa-dot-circle-o text-success\"></i> فعال <i");
            BeginWriteAttribute("class", " class=\"", 3799, "\"", 3807, 0);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n");
#nullable restore
#line 90 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-white btn-sm rounded dropdown-toggle\"");
            BeginWriteAttribute("value", " value=\"", 4096, "\"", 4104, 0);
            EndWriteAttribute();
            WriteLiteral(" readonly=\"readonly\">\r\n                                                <i class=\"fa fa-dot-circle-o text-danger\"></i> غیرفعال <i");
            BeginWriteAttribute("class", " class=\"", 4233, "\"", 4241, 0);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n");
#nullable restore
#line 96 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>

                                    <td class=""text-right"">
                                        <div class=""dropdown"">
                                            <a href=""#"" class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""fa fa-ellipsis-v""></i></a>
                                            <ul class=""dropdown-menu pull-right"">
                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 4826, "\"", 4879, 2);
            WriteAttributeValue("", 4833, "/Admin/Products/EditProduct/", 4833, 28, true);
#nullable restore
#line 104 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 4861, product.ProductId, 4861, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\"><i class=\"fa fa-pencil m-l-5\"></i> ویرایش</a></li>\r\n                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 5000, "\"", 5055, 2);
            WriteAttributeValue("", 5007, "/Admin/Products/DeleteProduct/", 5007, 30, true);
#nullable restore
#line 105 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 5037, product.ProductId, 5037, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete\"><i class=\"fa fa-trash-o m-l-5\"></i> حذف</a></li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 110 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel-footer\">\r\n                <div>\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 118 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                         for (int i = 1; i <= Model.ProductForProductListViewModel.PageCount; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 5708, "\"", 5800, 2);
            WriteAttributeValue("", 5716, "paginate_button", 5716, 15, true);
#nullable restore
#line 120 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue(" ", 5731, (i==Model.ProductForProductListViewModel.CurrentPage)?"active":"", 5732, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5886, "\"", 5918, 2);
            WriteAttributeValue("", 5893, "/Admin/Products?PageId=", 5893, 23, true);
#nullable restore
#line 121 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
WriteAttributeValue("", 5916, i, 5916, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 121 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 123 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.web.Pages.Admin.Products.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.web.Pages.Admin.Products.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.web.Pages.Admin.Products.IndexModel>)PageContext?.ViewData;
        public SadafStore.web.Pages.Admin.Products.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
