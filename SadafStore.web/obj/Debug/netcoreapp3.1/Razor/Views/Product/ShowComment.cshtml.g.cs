#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d305a58a72fefa4f80e9fabe67b9714959c8db7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowComment), @"mvc.1.0.view", @"/Views/Product/ShowComment.cshtml")]
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
#line 1 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
using SadafStore.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d305a58a72fefa4f80e9fabe67b9714959c8db7", @"/Views/Product/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<SadafStore.DataLayer.Entities.Product.ProductComment>, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
 foreach (var item in Model.Item1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"comment_thmb\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 228, "\"", 266, 2);
            WriteAttributeValue("", 234, "/AvatarsImg/", 234, 12, true);
#nullable restore
#line 11 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
WriteAttributeValue("", 246, item.User.AvatarImg, 246, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 267, "\"", 273, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"comment_text\">\r\n        <div class=\"reviews_meta\">\r\n\r\n            <p><strong>");
#nullable restore
#line 16 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
                  Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>");
#nullable restore
#line 16 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
                                               Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <p>\r\n            ");
#nullable restore
#line 19 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
       Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 22 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 27 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
         for (int i = 1; i <= Model.Item2; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 735, "\"", 760, 3);
            WriteAttributeValue("", 745, "pageComment(", 745, 12, true);
#nullable restore
#line 29 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
WriteAttributeValue("", 757, i, 757, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 759, ")", 759, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Product\ShowComment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<SadafStore.DataLayer.Entities.Product.ProductComment>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
