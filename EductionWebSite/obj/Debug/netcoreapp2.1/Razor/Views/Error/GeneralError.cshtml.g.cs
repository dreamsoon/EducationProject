#pragma checksum "F:\My Appliction\Web\EducationProject\EductionWebSite\Views\Error\GeneralError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3518d0ccaa007f42a9320a6eac61e943db787131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_GeneralError), @"mvc.1.0.view", @"/Views/Error/GeneralError.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/GeneralError.cshtml", typeof(AspNetCore.Views_Error_GeneralError))]
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
#line 1 "F:\My Appliction\Web\EducationProject\EductionWebSite\Views\_ViewImports.cshtml"
using EductionWeb;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3518d0ccaa007f42a9320a6eac61e943db787131", @"/Views/Error/GeneralError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08faf392d63bee30d178a260a553910c23cc88e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_GeneralError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\My Appliction\Web\EducationProject\EductionWebSite\Views\Error\GeneralError.cshtml"
  
    var ErrorMessage = " خطا- لطفا با مدیر سیستم تماس بگیرید";
    if (Model == 404)
    {
        ErrorMessage = " آدرس صفحه مورد نظر معتیر نیست ";
    }
    if (Model == 401 || Model == 403)
    {
        ErrorMessage = " شما مجوز چنین عملیاتی را ندارید ";
    }
    if (Model >= 500)
    {
        ErrorMessage = " خطای سرور- لطفا با مدیر سیستم تماس بگیرید";

    }


#line default
#line hidden
#line 19 "F:\My Appliction\Web\EducationProject\EductionWebSite\Views\Error\GeneralError.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(459, 64, true);
            WriteLiteral("    <div class=\"jumbotron h4 text-danger text-center\">\r\n        ");
            EndContext();
            BeginContext(524, 12, false);
#line 23 "F:\My Appliction\Web\EducationProject\EductionWebSite\Views\Error\GeneralError.cshtml"
   Write(ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(536, 13, true);
            WriteLiteral("\r\n    </div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int?> Html { get; private set; }
    }
}
#pragma warning restore 1591
