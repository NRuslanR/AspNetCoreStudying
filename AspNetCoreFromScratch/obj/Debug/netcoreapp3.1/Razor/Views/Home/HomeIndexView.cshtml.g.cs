#pragma checksum "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db22d072db6e37a6d47e4e576cc0a98d640089a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeIndexView), @"mvc.1.0.view", @"/Views/Home/HomeIndexView.cshtml")]
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
#line 1 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
using AspNetCoreFromScratch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
using AspNetCoreFromScratch.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db22d072db6e37a6d47e4e576cc0a98d640089a", @"/Views/Home/HomeIndexView.cshtml")]
    public class Views_Home_HomeIndexView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
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
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<!DOCTYPE HTML>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db22d072db6e37a6d47e4e576cc0a98d640089a3426", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <title>");
#nullable restore
#line 14 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db22d072db6e37a6d47e4e576cc0a98d640089a4665", async() => {
                WriteLiteral("\n");
#nullable restore
#line 17 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
Write(Styles.headerWrap(
        Model.Content, 
        HeaderLevel.h1, 
        $"color: {Colors.Value.TextColor}; background: {Colors.Value.BackgroundColor}"
    
    ));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n");
#nullable restore
#line 23 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
Write(Styles.paragraphWrap(Model.Status, $"color: {Colors.Value.TextColor}"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n<h2>");
#nullable restore
#line 24 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/AspNetCoreFromScratch/Views/Home/HomeIndexView.cshtml"
Write(Model.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n<h3>\n    <environment include=\"Development\">\n        Development Environment\n    </environment>\n    <environment include=\"Production\">\n        Production Environment\n    </environment>\n</h3>\n");
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
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<ColorOptions> Colors { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStyles Styles { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
