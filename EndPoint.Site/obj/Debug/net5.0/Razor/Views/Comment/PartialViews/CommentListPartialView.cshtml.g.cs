#pragma checksum "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ec32962514551bee82fb4e16050fca0169824e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_PartialViews_CommentListPartialView), @"mvc.1.0.view", @"/Views/Comment/PartialViews/CommentListPartialView.cshtml")]
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
#line 2 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
using EndPoint.Site.Extention;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ec32962514551bee82fb4e16050fca0169824e", @"/Views/Comment/PartialViews/CommentListPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03111cf058bf42aa4463a60152351bcacee2009f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_PartialViews_CommentListPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.News.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
      

        foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- start each comment -->\r\n            <li>\r\n                <img src=\"img/thumb.png\">\r\n                <div>\r\n                    <span> ");
#nullable restore
#line 14 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
                      Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                    <span> ");
#nullable restore
#line 15 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
                      Write(i.CreateDate.toShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                </div>\r\n                <p>");
#nullable restore
#line 17 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
              Write(i.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </li>\r\n            <!-- end each comment -->\r\n");
#nullable restore
#line 20 "E:\project\asp.net core\CMS.3\EndPoint.Site\Views\Comment\PartialViews\CommentListPartialView.cshtml"
        }



    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.News.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591