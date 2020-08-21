#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179148230eba24606a1c411b6b235af7d1d58802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179148230eba24606a1c411b6b235af7d1d58802", @"/Pages/Admin/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
  
    ViewData["Title"] = "لیست نقش ها";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card-box"">
            <div>
                <ol class=""linkinhead "">
                    <li><a href=""/"">خانه</a></li>
                    <li><a href=""/Admin"">داشبورد مدیریت</a></li>
                    <li class=""#"">لیست نقش‌ها</li>
                </ol>
            </div>
        </div>
    </div>
</div>


<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""panel panel-table"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-md-5"">
                        <a href=""/admin/roles/createrole"">
                            <button type=""button"" class=""btn btn-success"">افزودن نقش جدید</button>
                        </a>
                        <a href=""/admin/users/deleterolelist"">
                            <button type=""button"" class=""btn btn-danger"">لیست و بازگردانی نقش‌های حذف شده</button>
                        </a>
                    ");
            WriteLiteral(@"</div>

                    <div class=""col-md-7"">
                        <h2 class=""table-title"">لیست کاربرها</h2>
                    </div>
                </div>
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-striped custom-table m-b-0"">
                        <thead>
                            <tr>
                                <th style=""min-width:200px;"">نقش</th>
                                <th class=""text-right"">اعمال</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 52 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
                             foreach (var role in Model.RolesList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td style=\"min-width: 200px;\">\r\n                                        <a href=\"#\" class=\"avatar\">B</a>\r\n                                        <h2><a href=\"#\">");
#nullable restore
#line 57 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
                                                   Write(role.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span> </span></a></h2>
                                    </td>

                                    <td class=""text-right"">
                                        <div class=""dropdown"">
                                            <a href=""#"" class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""fa fa-ellipsis-v""></i></a>
                                            <ul class=""dropdown-menu pull-right"">
                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2651, "\"", 2692, 2);
            WriteAttributeValue("", 2658, "/Admin/Roles/EditRole/", 2658, 22, true);
#nullable restore
#line 64 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 2680, role.RoleId, 2680, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\"><i class=\"fa fa-pencil m-l-5\"></i> ویرایش</a></li>\r\n                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2813, "\"", 2856, 2);
            WriteAttributeValue("", 2820, "/Admin/Roles/DeleteRole/", 2820, 24, true);
#nullable restore
#line 65 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
WriteAttributeValue("", 2844, role.RoleId, 2844, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Delete\"><i class=\"fa fa-trash-o m-l-5\"></i> حذف</a></li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel-footer\">\r\n                <div>\r\n                    <ul class=\"pagination\">\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.Web.Pages.Admin.Roles.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.Web.Pages.Admin.Roles.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.Web.Pages.Admin.Roles.IndexModel>)PageContext?.ViewData;
        public SadafStore.Web.Pages.Admin.Roles.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
