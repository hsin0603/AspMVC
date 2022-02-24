#pragma checksum "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946a50bc9e33cbd43a3e09b76b92926a6ce2d8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Opera_Index), @"mvc.1.0.view", @"/Views/Opera/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946a50bc9e33cbd43a3e09b76b92926a6ce2d8f3", @"/Views/Opera/Index.cshtml")]
    public class Views_Opera_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarterM.Models.Opera>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "946a50bc9e33cbd43a3e09b76b92926a6ce2d8f32894", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "946a50bc9e33cbd43a3e09b76b92926a6ce2d8f33953", async() => {
                WriteLiteral("\r\n    <h1>Opera List</h1>\r\n    <table border=\"1\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.OperaID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Composer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayFor(m => item.OperaID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayFor(m => item.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
               Write(Html.DisplayFor(m => item.Composer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\public\mod03\04_database\StarterM\Views\Opera\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarterM.Models.Opera>> Html { get; private set; }
    }
}
#pragma warning restore 1591
