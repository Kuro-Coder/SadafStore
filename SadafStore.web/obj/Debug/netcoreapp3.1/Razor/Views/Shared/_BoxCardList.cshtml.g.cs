#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ada3e9d92eaf38bf98565967118b43a08aec79c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxCardList), @"mvc.1.0.view", @"/Views/Shared/_BoxCardList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ada3e9d92eaf38bf98565967118b43a08aec79c", @"/Views/Shared/_BoxCardList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BoxCardList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SadafStore.Core.DTOs.ProductViewModels.ShowProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n    <article class=\"single_product\">\r\n        <figure>\r\n            <div class=\"product_thumb maxWidth\">\r\n                <a class=\"primary_img\"");
            BeginWriteAttribute("href", " href=\"", 260, "\"", 289, 2);
            WriteAttributeValue("", 267, "/ShowProduct/", 267, 13, true);
#nullable restore
#line 7 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 280, Model.Id, 280, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"height: 329px; width: 329px;\"");
            BeginWriteAttribute("src", " src=\"", 332, "\"", 367, 2);
            WriteAttributeValue("", 338, "/ProductImg/images/", 338, 19, true);
#nullable restore
#line 7 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 357, Model.Img, 357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 368, "\"", 374, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <a class=\"secondary_img\"");
            BeginWriteAttribute("href", " href=\"", 422, "\"", 451, 2);
            WriteAttributeValue("", 429, "/ShowProduct/", 429, 13, true);
#nullable restore
#line 8 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 442, Model.Id, 442, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"height: 400px; width: 400px;\"");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 529, 2);
            WriteAttributeValue("", 500, "/ProductImg/images/", 500, 19, true);
#nullable restore
#line 8 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 519, Model.Img, 519, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 530, "\"", 536, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <div class=""label_product"">
                    <span class=""label_sale"">فروش</span>
                </div>
            </div>

            <div class=""product_content grid_content"">
                <div class=""product_content_inner"">
                    <h4 class=""product_name""><a");
            BeginWriteAttribute("href", " href=\"", 849, "\"", 878, 2);
            WriteAttributeValue("", 856, "/ShowProduct/", 856, 13, true);
#nullable restore
#line 16 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 869, Model.Id, 869, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                                                         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <div class=\"price_box\">\r\n                        <span class=\"current_price\">");
#nullable restore
#line 18 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                                Write((Model.NewPrice == 0) ? "رایگان" : Model.NewPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                        <span class=\"old_price\">");
#nullable restore
#line 19 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                            Write((Model.OldPrice == 0) ? "رایگان" : Model.OldPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"add_to_cart\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1367, 2);
            WriteAttributeValue("", 1338, "/Product/BuyProduct/", 1338, 20, true);
#nullable restore
#line 23 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 1358, Model.Id, 1358, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1368, "\"", 1376, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"افزودن به سبد\">افزودن به سبد</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"product_content list_content\">\r\n                <h4 class=\"product_name\"><a");
            BeginWriteAttribute("href", " href=\"", 1576, "\"", 1605, 2);
            WriteAttributeValue("", 1583, "/ShowProduct/", 1583, 13, true);
#nullable restore
#line 27 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 1596, Model.Id, 1596, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                <div class=\"price_box\">\r\n                    <span class=\"current_price\">");
#nullable restore
#line 29 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                            Write((Model.NewPrice == 0) ? "رایگان" : Model.NewPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                    <span class=\"old_price\">");
#nullable restore
#line 30 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                                        Write((Model.OldPrice == 0) ? "رایگان" : Model.OldPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                </div>\r\n                <div class=\"product_desc\">\r\n                    <p>");
#nullable restore
#line 33 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
                  Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"add_to_cart\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2138, "\"", 2174, 2);
            WriteAttributeValue("", 2145, "/Product/BuyProduct/", 2145, 20, true);
#nullable restore
#line 36 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCardList.cshtml"
WriteAttributeValue("", 2165, Model.Id, 2165, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2175, "\"", 2183, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"افزودن به سبد\">افزودن به سبد</a>\r\n                </div>\r\n            </div>\r\n        </figure>\r\n    </article>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SadafStore.Core.DTOs.ProductViewModels.ShowProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
