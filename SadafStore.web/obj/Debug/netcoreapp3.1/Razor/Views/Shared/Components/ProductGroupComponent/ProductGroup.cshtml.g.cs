#pragma checksum "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfddc28155d708189e1a6cd707e2b80ee38f2a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductGroupComponent_ProductGroup), @"mvc.1.0.view", @"/Views/Shared/Components/ProductGroupComponent/ProductGroup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfddc28155d708189e1a6cd707e2b80ee38f2a5a", @"/Views/Shared/Components/ProductGroupComponent/ProductGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductGroupComponent_ProductGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SadafStore.DataLayer.Entities.Product.Group>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"categories_menu\">\r\n    <div class=\"categories_title\">\r\n        <h2 class=\"categori_toggle\">دسته بندی ها</h2>\r\n    </div>\r\n    <div class=\"categories_menu_toggle\" style=\"display: none\">\r\n        <ul>\r\n");
#nullable restore
#line 10 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
             foreach (var group in Model.Where(g => g.ParentId == null))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li name=\"selectedGroups\" class=\"menu_item_children\">\r\n                    <a onchange=\"changeGroup()\"");
            BeginWriteAttribute("href", " href=\"", 488, "\"", 533, 2);
            WriteAttributeValue("", 495, "/Product?selectedGroups=", 495, 24, true);
#nullable restore
#line 13 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
WriteAttributeValue("", 519, group.GroupId, 519, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                                                                         Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa fa-angle-left\"></i></a>\r\n");
#nullable restore
#line 14 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                     if (Model.Any(g => g.ParentId == group.GroupId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"categories_mega_menu\">\r\n");
#nullable restore
#line 17 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                             foreach (var subGroupLevel1 in Model.Where(g => g.ParentId == group.GroupId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li name=\"selectedGroups\" class=\"menu_item_children\">\r\n                                    <a onchange=\"changeGroup()\"");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1087, 2);
            WriteAttributeValue("", 1040, "/Product?selectedGroups=", 1040, 24, true);
#nullable restore
#line 20 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
WriteAttributeValue("", 1064, subGroupLevel1.GroupId, 1064, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                                                                                                  Write(subGroupLevel1.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 21 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                     if (Model.Any(g => g.ParentId == subGroupLevel1.GroupId))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul class=\"categorie_sub_menu\">\r\n");
#nullable restore
#line 24 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                             foreach (var subGroupLevel2 in Model.Where(g => g.ParentId == subGroupLevel1.GroupId))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li name=\"selectedGroups\"><a onchange=\"changeGroup()\"");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1664, 2);
            WriteAttributeValue("", 1617, "/Product?selectedGroups=", 1617, 24, true);
#nullable restore
#line 26 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
WriteAttributeValue("", 1641, subGroupLevel2.GroupId, 1641, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                                                                                                                                        Write(subGroupLevel2.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 27 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\r\n");
#nullable restore
#line 29 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </li>\r\n");
#nullable restore
#line 31 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n");
#nullable restore
#line 34 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 36 "F:\MyProject Core\SadafStore\SadafStore.web\Views\Shared\Components\ProductGroupComponent\ProductGroup.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n        function changeGroup() {\r\n            $(\"#formFilter\").submit();\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SadafStore.DataLayer.Entities.Product.Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
