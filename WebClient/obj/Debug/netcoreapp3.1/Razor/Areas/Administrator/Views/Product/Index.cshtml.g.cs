#pragma checksum "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0790890bf99c7522c467a5dfc2b2251a2f734041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Product/Index.cshtml")]
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
#line 1 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0790890bf99c7522c467a5dfc2b2251a2f734041", @"/Areas/Administrator/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3633226d43c224cd55f6d52f7b692ce96f699ea", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
  
    Layout = "_LayoutHome";
    ViewData["Title"] = "ManagerProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""/css/style.css"" rel=""stylesheet"" />
<div class=""table-area"">
    <h1>Quản Lý Sản Phẩm</h1>
    <button class=""create-btn""><a href=""/administrator/product/create"">Tạo mới</a></button>
    <table>
        <thead>
            <tr>
                <th>Id</th>
                <th style=""width:65px;"">Danh mục Id</th>
                <th>Tên</th>
                <th>Miêu tả</th>
                <th>Giá</th>
                <th>Số lượng</th>
                <th>Hình ảnh</th>
                <th>Sửa</th>
                <th>Xoá</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 28 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 31 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 35 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                         if (item.ImageUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1156, "\"", 1184, 2);
            WriteAttributeValue("", 1162, "/upload/", 1162, 8, true);
#nullable restore
#line 37 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 1170, item.ImageUrl, 1170, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" />\n");
#nullable restore
#line 38 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                    <td>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1347, 2);
            WriteAttributeValue("", 1311, "/administrator/product/edit/", 1311, 28, true);
#nullable restore
#line 41 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 1339, item.Id, 1339, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <img src=\"/images/edit.png\" />\n                        </a>\n                    </td>\n                    <td>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1515, "\"", 1560, 2);
            WriteAttributeValue("", 1522, "/administrator/product/delete/", 1522, 30, true);
#nullable restore
#line 46 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 1552, item.Id, 1552, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <img src=\"/images/trash.png\" />\n                        </a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 51 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591