#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c014aab3e76800bd009aab3d894c6c96b45d1d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Home_Index), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
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
#line 2 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
using SadafStore.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c014aab3e76800bd009aab3d894c6c96b45d1d21", @"/Areas/UserPanel/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SadafStore.Core.DTOs.UserPanelViewModel.InformationUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavTabs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "حساب کاربری " + User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--breadcrumbs area start-->
<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-3"">
            </div>
            <div class=""col-6"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""/"">خانه</a></li>
                        <li>داشبورد</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--breadcrumbs area end-->

<div class=""account_page_bg"">
    <div class=""container"">
        <section class=""main_content_area"">
            <div class=""account_dashboard"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-3 col-lg-3"">
                        <!-- Nav tabs -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c014aab3e76800bd009aab3d894c6c96b45d1d214458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""col-sm-12 col-md-9 col-lg-9"">
                        <!-- Tab panes -->
                        <div class=""tab-content dashboard_content"">
                            <div class=""tab-pane fade active show"" id=""dashboard"">
                                <h3>داشبورد اطلاعات شما </h3>
                                <ul>
                                    <li>  ایمیل : ");
#nullable restore
#line 42 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li>  نام و نام خانوادگی :  ");
#nullable restore
#line 43 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                           Write(Model.AvatarName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li>  شماره تماس : ");
#nullable restore
#line 44 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                  Write(Model.TelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li>  آدرس : ");
#nullable restore
#line 45 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                            Write(Model.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li>  تاریخ عضویت : ");
#nullable restore
#line 46 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                   Write(Model.RegisterDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li>  موجودی حساب : ");
#nullable restore
#line 47 "F:\MyProject Core\SadafStore\SadafStore.web\Areas\UserPanel\Views\Home\Index.cshtml"
                                                   Write(Model.Wallet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان </li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.Core.DTOs.UserPanelViewModel.InformationUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
