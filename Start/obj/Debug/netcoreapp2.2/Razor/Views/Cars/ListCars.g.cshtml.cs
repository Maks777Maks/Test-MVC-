#pragma checksum "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "204efe5bd19d65e14d9d50ea3f342126594e0940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ListCars), @"mvc.1.0.view", @"/Views/Cars/ListCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/ListCars.cshtml", typeof(AspNetCore.Views_Cars_ListCars))]
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
#line 1 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\_ViewImports.cshtml"
using Start;

#line default
#line hidden
#line 2 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\_ViewImports.cshtml"
using Start.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204efe5bd19d65e14d9d50ea3f342126594e0940", @"/Views/Cars/ListCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27c5daccd6be6cd39384be0392c9649397c9dc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_ListCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(146, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(175, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204efe5bd19d65e14d9d50ea3f342126594e09403739", async() => {
                BeginContext(181, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ListCars</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(278, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(280, 501, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204efe5bd19d65e14d9d50ea3f342126594e09405017", async() => {
                BeginContext(286, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(297, 13, false);
#line 19 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(310, 40, true);
                WriteLiteral("</h1>\r\n    <div class=\"row mt-5 mb-2\">\r\n");
                EndContext();
#line 21 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
          
            foreach (var item in Model.GetCars)
            {

#line default
#line hidden
                BeginContext(426, 82, true);
                WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <img class=\"thumbnail\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 508, "\"", 525, 1);
#line 25 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
WriteAttributeValue("", 514, item.Image, 514, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(526, 35, true);
                WriteLiteral(" />\r\n                    <p>Model: ");
                EndContext();
                BeginContext(562, 9, false);
#line 26 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
                         Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(571, 37, true);
                WriteLiteral("</p>\r\n                    <p>Price:  ");
                EndContext();
                BeginContext(609, 24, false);
#line 27 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
                          Write(item.Price.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(633, 103, true);
                WriteLiteral("</p>\r\n                    <p><a class=\"btn btn-warning\" href=\"#\">Info</a></p>\r\n                </div>\r\n");
                EndContext();
#line 30 "C:\Users\Novak\Desktop\HTML LESSONS\MVC(CORE)\Start\Start\Views\Cars\ListCars.cshtml"
            }
        

#line default
#line hidden
                BeginContext(762, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
