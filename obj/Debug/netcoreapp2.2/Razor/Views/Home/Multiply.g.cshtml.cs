#pragma checksum "D:\Visual\Web1.1\Views\Home\Multiply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a9e23f982555c68efe2fc3c3236f6293e9592c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Multiply), @"mvc.1.0.view", @"/Views/Home/Multiply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Multiply.cshtml", typeof(AspNetCore.Views_Home_Multiply))]
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
#line 1 "D:\Visual\Web1.1\Views\_ViewImports.cshtml"
using Web1._1;

#line default
#line hidden
#line 2 "D:\Visual\Web1.1\Views\_ViewImports.cshtml"
using Web1._1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a9e23f982555c68efe2fc3c3236f6293e9592c", @"/Views/Home/Multiply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9c82462d7a19df60f73eac165575d9e95b7f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Multiply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Visual\Web1.1\Views\Home\Multiply.cshtml"
  
    ViewData["Title"] = "Multiply";

#line default
#line hidden
            BeginContext(46, 40, true);
            WriteLiteral("\r\n<h2>Multiply</h2>\r\n\r\nMulthiply value =");
            EndContext();
            BeginContext(87, 15, false);
#line 8 "D:\Visual\Web1.1\Views\Home\Multiply.cshtml"
            Write(ViewData["sum"]);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
