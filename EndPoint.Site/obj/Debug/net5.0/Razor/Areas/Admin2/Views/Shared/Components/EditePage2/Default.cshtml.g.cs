#pragma checksum "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4368f638e13cd3bc6b6b7ca6f39a4d596acf6bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin2_Views_Shared_Components_EditePage2_Default), @"mvc.1.0.view", @"/Areas/Admin2/Views/Shared/Components/EditePage2/Default.cshtml")]
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
#line 1 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"
using EndPoint.Site.Extention;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4368f638e13cd3bc6b6b7ca6f39a4d596acf6bac", @"/Areas/Admin2/Views/Shared/Components/EditePage2/Default.cshtml")]
    #nullable restore
    public class Areas_Admin2_Views_Shared_Components_EditePage2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EndPoint.Site.Areas.Admin.Models.PageModelView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"








    <form role=""form"" enctype=""multipart/form-data"" asp-action=""CreatePage"" asp-controller=""Adding"" method=""post"">
        <div class=""box-body"">


            <div class=""form-group"">
                <label>معمولی</label>
                <select class=""form-control select2"" name=""PageGroup"" style=""width: 100%;"">
");
#nullable restore
#line 19 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"
                      
                        int s = 0;
                        foreach (var i in ViewBag.groups)
                        {
                            if (s == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option selected=\"selected\">");
#nullable restore
#line 25 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"
                                                       Write(i.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <option>");
#nullable restore
#line 29 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"
                                   Write(i.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "E:\project\asp.net core\CMS.3\EndPoint.Site\Areas\Admin2\Views\Shared\Components\EditePage2\Default.cshtml"

                            }
                            s++;
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>

            <div class=""form-group"">
                <label>انتخاب تاریخ شمسی با خروجی تایم استمپ </label>
                <div class=""input-group date"">
                    <div class=""input-group-addon"">
                        <i class=""fa fa-calendar""></i>
                    </div>
                    <input type=""text"" id=""tarikh"" class=""form-control pull-right"">
                    <input type=""text"" name=""CreateDate"" id=""tarikhAlt"" class=""form-control pull-right"" hidden>
                </div>
                <!-- /.input group -->
                <br>
            </div>

            <div class=""form-group  "">
                <label for=""exampleInputEmail1"">عنوان</label>
                <input type=""text"" name=""PageTitle"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""عنوان"">
            </div>

            <div class=""form-group "">
                <label>توضیح کوتاه</label>
                <textarea class=""form-control"" n");
            WriteLiteral("ame=\"ShortDescription\" rows=\"3\" placeholder=\"توضیح کوتاه\"></textarea>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group\">\r\n");
            WriteLiteral(@"                <textarea id=""my-textarea"" name=""Text""></textarea>
            </div>

            <div class=""form-group"">
                <label for=""exampleInputFile"">ارسال فایل</label>
                <input type=""file"" name=""Image"" id=""exampleInputFile"">

                <p class=""help-block"">متن راهنما</p>
            </div>

            <div class=""form-group"">
                <label for=""exampleInputFile"">کلمات کلیدی</label>
                <input type=""text"" name=""Tags"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""کلمات کلیدی"">
            </div>


            <div class=""checkbox"">
                <label>
                    <input type=""checkbox""> مرا به خاطر بسپار
                </label>
            </div>
        </div>
        <!-- /.box-body -->

        <div class=""box-footer"">
            <button type=""submit"" class=""btn btn-primary"">ارسال</button>
        </div>
    </form>









");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EndPoint.Site.Areas.Admin.Models.PageModelView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
