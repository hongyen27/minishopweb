#pragma checksum "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c2d6e4c74d5a4ecd89f7f0e2cab4059c631ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Product_Edit), @"mvc.1.0.view", @"/Areas/Administrator/Views/Product/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c2d6e4c74d5a4ecd89f7f0e2cab4059c631ea1", @"/Areas/Administrator/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3633226d43c224cd55f6d52f7b692ce96f699ea", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-custom2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table-area\">\n    <h1>Chỉnh sửa sản phẩm</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c2d6e4c74d5a4ecd89f7f0e2cab4059c631ea15001", async() => {
                WriteLiteral("\n        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 223, "\"", 240, 1);
#nullable restore
#line 8 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 231, Model.Id, 231, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        <div>\n            <label>Danh mục</label>\n            <select style=\"border:1px solid #1A73E8;outline-color:1A73E8;\" name=\"CategoryId\">\n");
#nullable restore
#line 12 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                 foreach (Category item in ViewBag.categories)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                     if (item.Id == Model.CategoryId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c2d6e4c74d5a4ecd89f7f0e2cab4059c631ea16509", async() => {
#nullable restore
#line 16 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 17 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c2d6e4c74d5a4ecd89f7f0e2cab4059c631ea18893", async() => {
#nullable restore
#line 21 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 22 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\n        </div>\n        <div>\n            <label>Tên</label>\n            <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 939, "\"", 958, 1);
#nullable restore
#line 29 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 947, Model.Name, 947, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        </div>\n        <div>\n            <label>Giá</label>\n            <input type=\"number\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 1068, "\"", 1088, 1);
#nullable restore
#line 33 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1076, Model.Price, 1076, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        </div>\n        <div>\n            <label>Số lượng</label>\n            <input type=\"number\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 1206, "\"", 1229, 1);
#nullable restore
#line 37 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1214, Model.Quantity, 1214, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        </div>\n        <div>\n            <label>Giảm giá</label>\n            <input type=\"text\" name=\"Temp_Discount\"");
                BeginWriteAttribute("value", " value=\"", 1350, "\"", 1373, 1);
#nullable restore
#line 41 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1358, Model.Discount, 1358, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" oninput=\"this.value = this.value.replace(/[^0-9.]/g, \'\').replace(/(\\..*)\\./g, \'$1\');\" />\n        </div>\n        <div>\n            <label>Mô tả</label>\n            <textarea style=\"outline-color: #1A73E8; border-color: #1A73E8;\" name=\"Description\">");
#nullable restore
#line 45 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
                                                                                           Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n        </div>\n        <div>\n            <label>Hình ảnh</label>\n            <input style=\"outline-color: #1A73E8; border-color: #1A73E8;\" type=\"hidden\" name=\"ImageUrl\"");
                BeginWriteAttribute("value", " value=\"", 1820, "\"", 1843, 1);
#nullable restore
#line 49 "D:\download\Documents\webdichvu\thuong\DA_ThayTru_HK1_Nam5-master\WebClient\Areas\Administrator\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1828, Model.ImageUrl, 1828, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <input style=\"border:none;outline-color:#1A73E8;border-color:#1A73E8;\" type=\"file\" name=\"f\" />\n        </div>\n        <button class=\"create-btn\"><a href=\"#\">Lưu</a></button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
