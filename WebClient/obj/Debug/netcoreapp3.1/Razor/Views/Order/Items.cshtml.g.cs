#pragma checksum "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82762103a81cec7af0e5373c7332a7e2c9841ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Items), @"mvc.1.0.view", @"/Views/Order/Items.cshtml")]
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
#line 1 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82762103a81cec7af0e5373c7332a7e2c9841ed2", @"/Views/Order/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c692906421f801507a7201e7123fcd42499e89c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItems>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
  
    ViewData["Title"] = "Items";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container-fluid\">\n\n    <h2 class=\"text-center\" style=\"text-transform: uppercase;font-size: 38px;color: #485650;font-weight: bold;\">\n        Đơn hàng\n    </h2>\n");
#nullable restore
#line 12 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
     if (User.IsInRole("Administrator") || User.IsInRole("Staff"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
         if (ViewBag.orders.Status == "P")
        {
          

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\">Hủy đơn hàng</a>\n                <a href=\"#\">Giao hàng</a>\n");
#nullable restore
#line 19 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
           
            
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
         

    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
         if (ViewBag.orders.Status == "P" || ViewBag.orders.Status == "C")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\">Hủy đơn hàng</a>\n");
#nullable restore
#line 29 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
         if (ViewBag.orders.Status == "X")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#\">Đặt hàng lại</a>\n");
#nullable restore
#line 33 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th style=""text-align: center;"">Tên sản phẩm</th>
                <th style=""text-align: center;"">Giá</th>
                <th style=""text-align: center;"">Số lượng</th>
                <th style=""text-align: center;"">Tổng tiền</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td style=\"width:15%;text-align:center\"><span style=\"text-align:center;font-size:20px;font-weight:bold\">");
#nullable restore
#line 50 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
                                                                                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  <img");
            BeginWriteAttribute("src", " src=\"", 1367, "\"", 1395, 2);
            WriteAttributeValue("", 1373, "/upload/", 1373, 8, true);
#nullable restore
#line 50 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
WriteAttributeValue("", 1381, item.ImageUrl, 1381, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" /></td>\n                    <td style=\"text-align: center;\">");
#nullable restore
#line 51 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td style=\"text-align: center;\">\n                        ");
#nullable restore
#line 53 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <th style=\"text-align: center;background: #fff;color: #000;\">");
#nullable restore
#line 55 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
                                                                             Write(item.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\n\n                </tr>\n");
#nullable restore
#line 59 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr class=""visible-xs"">
                <td class=""text-center"">
                </td>
            </tr>
            <tr>

                <td colspan=""3"" class=""hidden-xs""> </td>
                <td class=""hidden-xs text-center"">
                    <strong>Tổng tiền :<span> ");
#nullable restore
#line 70 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Views\Order\Items.cshtml"
                                         Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</span> </strong>\n                </td>\n                <td>\n                </td>\n            </tr>\n        </tfoot>\n\n\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItems>> Html { get; private set; }
    }
}
#pragma warning restore 1591
