#pragma checksum "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78824d37bb79f6f01f6e732ddd5c742eaa7ef5d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Search), @"mvc.1.0.view", @"/Views/Page/Search.cshtml")]
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
#line 1 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
using EndPoint.Site.Extention;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78824d37bb79f6f01f6e732ddd5c742eaa7ef5d0", @"/Views/Page/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03111cf058bf42aa4463a60152351bcacee2009f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Page_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EndPoint.Site.Models.PageViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"last-news-section border-radius\">\r\n    <header><i class=\"icons icon-doc-2\"></i>  <h3> ");
#nullable restore
#line 12 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" نتیجه یافت شد </h3> </header>\r\n    <ul>\r\n\r\n");
#nullable restore
#line 15 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
          
            foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <img class=\"border-radius\"");
            BeginWriteAttribute("src", " src=\"", 479, "\"", 493, 1);
#nullable restore
#line 19 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
WriteAttributeValue("", 485, i.Image, 485, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78824d37bb79f6f01f6e732ddd5c742eaa7ef5d05059", async() => {
                WriteLiteral("  ");
#nullable restore
#line 20 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
                                                        Write(i.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 531, "~/Page/GetPage?id=", 531, 18, true);
#nullable restore
#line 20 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
AddHtmlAttributeValue("", 549, i.id, 549, 5, false);

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
            WriteLiteral("</h2>\r\n                    <p>\r\n                        ");
#nullable restore
#line 22 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
                   Write(i.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <span class=\"date-publish\"><i class=\"fa fa-calendar\"></i> انتشار : ");
#nullable restore
#line 24 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
                                                                                  Write(i.CreateDate.toShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78824d37bb79f6f01f6e732ddd5c742eaa7ef5d07566", async() => {
                WriteLiteral("<i class=\"icons icon-more\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 828, "~/Page/GetPage?id=", 828, 18, true);
#nullable restore
#line 25 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
AddHtmlAttributeValue("", 846, i.id, 846, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 27 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Page\Search.cshtml"
            }


        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EndPoint.Site.Models.PageViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
