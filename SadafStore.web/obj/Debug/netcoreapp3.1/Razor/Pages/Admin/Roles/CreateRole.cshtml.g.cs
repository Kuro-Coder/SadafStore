#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e672b061464bfdc0396587bb8c9cc0e184b3bec4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
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
#line 2 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
using SadafStore.DataLayer.Entities.Permissions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e672b061464bfdc0396587bb8c9cc0e184b3bec4", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("نام نقش را وارد کنید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

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
                    <li><a href=""/Admin"">پنل مدیریت</a></li>
                    <li><a href=""/Admin/Roles"">لیست نقش‌ها</a></li>
                    <li class=""#"">افزودن نقش جدید</li>
                </ol>
            </div>
        </div>
    </div>
</div>

<div class=""card-box"">
    <div class=""row"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e672b061464bfdc0396587bb8c9cc0e184b3bec46075", async() => {
                WriteLiteral(@"
            <h4 class=""card-title"">ایجاد نقش جدید</h4>
            <div class=""col-md-8"">
                <div class=""form-group"">
                    <label class=""control-label col-md-2"">نام نقش :</label>
                    <div class=""col-md-10"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e672b061464bfdc0396587bb8c9cc0e184b3bec46622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 33 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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

                <button type=""submit"" class=""btn btn-success"">ایجاد نقش جدید</button>
            </div>
            <div class=""col-md-4"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        دسترسی‌های این نقش
                    </div>
                    <div class=""panel-body"">
                        <div class=""form-group"">
                            <label style=""padding: 0px 10px"">انتخاب دسترسی</label>
                            <div");
                BeginWriteAttribute("class", " class=\"", 1798, "\"", 1806, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"padding: 0px 20px\">\r\n                                <ul>\r\n");
#nullable restore
#line 49 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                     foreach (var permission in permissions.Where(p => p.ParentId == null))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            <input type=\"checkbox\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 2160, "\"", 2192, 1);
#nullable restore
#line 52 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2168, permission.PermissionId, 2168, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 52 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                            Write(permission.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 54 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                             if (permissions.Any(p => p.ParentId == permission.ParentId))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <ul>\r\n");
#nullable restore
#line 57 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                     foreach (var sub in permissions.Where(p => p.ParentId == permission.PermissionId))
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <li>\r\n                                                            <input type=\"checkbox\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 2798, "\"", 2823, 1);
#nullable restore
#line 60 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2806, sub.PermissionId, 2806, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 60 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                     Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 61 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                             if (permissions.Any(p => p.ParentId == sub.ParentId))
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <ul>\r\n\r\n");
#nullable restore
#line 65 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                     foreach (var sub2 in permissions.Where(p => p.ParentId == sub.PermissionId))
                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                        <li>\r\n                                                                            <input type=\"checkbox\" name=\"SelectedPermission\"");
                BeginWriteAttribute("value", " value=\"", 3521, "\"", 3547, 1);
#nullable restore
#line 68 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 3529, sub2.PermissionId, 3529, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 68 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                                      Write(sub2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                                        </li>\r\n");
#nullable restore
#line 70 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                </ul>\r\n");
#nullable restore
#line 72 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        </li>\r\n");
#nullable restore
#line 74 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 76 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </li>\r\n");
#nullable restore
#line 78 "F:\MyProject Core\SadafStore\SadafStore.web\Pages\Admin\Roles\CreateRole.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.Web.Pages.Admin.Roles.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.Web.Pages.Admin.Roles.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SadafStore.Web.Pages.Admin.Roles.CreateRoleModel>)PageContext?.ViewData;
        public SadafStore.Web.Pages.Admin.Roles.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
