#pragma checksum "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a0434ad2e78588adfeeae4a4b356e63b3916a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a0434ad2e78588adfeeae4a4b356e63b3916a4", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RamasPieShop.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 9, true);
            WriteLiteral("    <h2> ");
            EndContext();
            BeginContext(56, 11, false);
#line 2 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(67, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 3 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
     foreach (var pie in Model.Pies)
    {

#line default
#line hidden
            BeginContext(119, 83, true);
            WriteLiteral("<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 202, "\"", 230, 1);
#line 7 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 208, pie.ImageThumbnailUrl, 208, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(231, 77, true);
            WriteLiteral(" alt=\"\"/>\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(309, 23, false);
#line 9 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
                              Write(pie.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(332, 41, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                ");
            EndContext();
            BeginContext(374, 8, false);
#line 11 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
           Write(pie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(382, 36, true);
            WriteLiteral("\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(419, 20, false);
#line 13 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
          Write(pie.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(439, 42, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 17 "E:\Learning\CoreMVC\RamasPieShop\RamasPieShop\Views\Home\Index.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RamasPieShop.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
