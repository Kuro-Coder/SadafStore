#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e471d483fd0340d80eaf609ca3197d90bf08e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxCard), @"mvc.1.0.view", @"/Views/Shared/_BoxCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e471d483fd0340d80eaf609ca3197d90bf08e0d", @"/Views/Shared/_BoxCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BoxCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SadafStore.Core.DTOs.ProductViewModels.ShowProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product_items\">\r\n    <article class=\"single_product\">\r\n        <figure>\r\n            <div class=\"product_thumb\">\r\n                <a class=\"primary_img\"");
            BeginWriteAttribute("href", " href=\"", 238, "\"", 267, 2);
            WriteAttributeValue("", 245, "/ShowProduct/", 245, 13, true);
#nullable restore
#line 7 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
WriteAttributeValue("", 258, Model.Id, 258, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"height: 150px\"");
            BeginWriteAttribute("src", " src=\"", 295, "\"", 331, 2);
            WriteAttributeValue("", 301, "/ProductImg/boxCard/", 301, 20, true);
#nullable restore
#line 7 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
WriteAttributeValue("", 321, Model.Img, 321, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 332, "\"", 338, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <a class=\"secondary_img\"");
            BeginWriteAttribute("href", " href=\"", 386, "\"", 415, 2);
            WriteAttributeValue("", 393, "/ShowProduct/", 393, 13, true);
#nullable restore
#line 8 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
WriteAttributeValue("", 406, Model.Id, 406, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img style=\"height: 160px\"");
            BeginWriteAttribute("src", " src=\"", 443, "\"", 479, 2);
            WriteAttributeValue("", 449, "/ProductImg/boxCard/", 449, 20, true);
#nullable restore
#line 8 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
WriteAttributeValue("", 469, Model.Img, 469, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 480, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <div class=\"label_product\">\r\n                    <span class=\"label_sale\">موجود</span>\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"product_content\">\r\n                <div class=\"product_content_inner\">\r\n                    <h4 class=\"product_name\"><a href=\"product-details.html\">");
#nullable restore
#line 22 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
                                                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <div class=\"price_box\">\r\n                        <span class=\"old_price\">");
#nullable restore
#line 24 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
                                            Write((Model.OldPrice==0)?"رایگان":Model.OldPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                        <span class=\"current_price\">");
#nullable restore
#line 25 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
                                                Write((Model.NewPrice==0)?"رایگان":Model.NewPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"add_to_cart\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1875, 2);
            WriteAttributeValue("", 1846, "/Product/BuyProduct/", 1846, 20, true);
#nullable restore
#line 29 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\_BoxCard.cshtml"
WriteAttributeValue("", 1866, Model.Id, 1866, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"افزودن به سبد\">افزودن به سبد</a>\r\n                </div>\r\n            </div>\r\n        </figure>\r\n    </article>\r\n</div>\r\n");
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
