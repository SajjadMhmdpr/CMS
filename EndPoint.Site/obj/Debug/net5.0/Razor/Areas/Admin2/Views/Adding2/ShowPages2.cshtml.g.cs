#pragma checksum "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd3cc877ed9a0e6ed835a376674fea964a9c22af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin2_Views_Adding2_ShowPages2), @"mvc.1.0.view", @"/Areas/Admin2/Views/Adding2/ShowPages2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3cc877ed9a0e6ed835a376674fea964a9c22af", @"/Areas/Admin2/Views/Adding2/ShowPages2.cshtml")]
    #nullable restore
    public class Areas_Admin2_Views_Adding2_ShowPages2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EndPoint.Site.Areas.Admin.Models.PageModelView>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DatePiker/dist/kamadatepicker.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-flat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DatePiker/dist/kamadatepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
  
    ViewData["Title"] = "ShowPages";
    Layout = "~/Areas/Admin2/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            DefineSection("Csss", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd3cc877ed9a0e6ed835a376674fea964a9c22af5137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    <style>\r\n        img {\r\n            height: 50px;\r\n            width: 50px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral(@"

<table class=""table table-hover table-striped"">
    <thead>
        <tr>
            <th>عکس</th>
            <th>گروه</th>
            <th>عنوان</th>
            <th>توضیح کوتاه</th>
            <th>امکانات</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 35 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
          
            foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 913, "\"", 929, 1);
#nullable restore
#line 40 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
WriteAttributeValue(" ", 919, i.Image2, 920, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 42 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
                   Write(i.PageGroup);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
                   Write(i.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
                   Write(i.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3cc877ed9a0e6ed835a376674fea964a9c22af8473", async() => {
                WriteLiteral("\r\n                                <i class=\"bi bi-info-circle\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1261, "~/Page/GetPage?id=", 1261, 18, true);
#nullable restore
#line 47 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
AddHtmlAttributeValue("", 1279, i.id, 1279, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3cc877ed9a0e6ed835a376674fea964a9c22af10218", async() => {
                WriteLiteral("\r\n                                <i class=\"bi bi-pencil\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1459, "~/Admin/Adding/EditePage/", 1459, 25, true);
#nullable restore
#line 50 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
AddHtmlAttributeValue("", 1484, i.id, 1484, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a class=\"btn btn-danger btn-flat\" href=\"https://www.zoomg.ir/cinema-news/\">\r\n                                <i class=\"bi bi-trash\"></i>\r\n                            </a>\r\n");
            WriteLiteral("                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 60 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Adding2\ShowPages2.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<input type=""text"" id=""cleander""/>



<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">New message</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>

            <div class=""modal-body"">
                <form>
                    <div class=""mb-3"">
                        <label for=""recipient-name"" class=""col-form-label"">Recipient:</label>
                        <input type=""text"" class=""form-control"" id=""recipient-name"">
                    </div>
                    <div class=""mb-3"">
                        <label for=""message-text"" class=""col-form-label"">Message:</label>
                        <textarea class=""form-control"" id=""message-text""></");
            WriteLiteral(@"textarea>
                    </div>
                </form>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Send message</button>
            </div>
        </div>
    </div>
</div>
















");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3cc877ed9a0e6ed835a376674fea964a9c22af14122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            kamaDatepicker('cleander', {
                buttonsColor: ""red"",
                forceFarsiDigits: true,
                markToday: true,
                markHolidays: true,
                gotoToday: true,
                nextButtonIcon:""bi-caret-right-fill"",
                previousButtonIcon:""bi-caret-left-fill""
            });

        })


    </script>


");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EndPoint.Site.Areas.Admin.Models.PageModelView>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
