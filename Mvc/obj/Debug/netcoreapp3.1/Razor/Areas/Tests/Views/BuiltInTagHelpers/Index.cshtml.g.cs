#pragma checksum "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f7623fa1e7574e73fc17e42ae2bd9522c50d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tests_Views_BuiltInTagHelpers_Index), @"mvc.1.0.view", @"/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml")]
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
#line 1 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f7623fa1e7574e73fc17e42ae2bd9522c50d61", @"/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1b723f423f1a97d1a961658293c2df24825f25", @"/Areas/Tests/Views/_ViewImports.cshtml")]
    public class Areas_Tests_Views_BuiltInTagHelpers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Tests.Model.BuiltInTagHelpers.BuiltInTagHelpersIndexViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
  
    ViewData["Title"] = "Built-In Tag Helpers - Index";
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 10 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<ul>\n");
#nullable restore
#line 12 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
     foreach (var tagHelperLink in Model.TagHelperLinks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\n");
#nullable restore
#line 15 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
             if (tagHelperLink.Url.ToLower().Contains("loginform"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 379, "\"", 445, 1);
#nullable restore
#line 17 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
WriteAttributeValue("", 386, tagHelperLink.Url + "?returnUrl=" + Context.Request.Path, 386, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
                                                                                 Write(tagHelperLink.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 18 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
            }

            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 563, 1);
#nullable restore
#line 22 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
WriteAttributeValue("", 545, tagHelperLink.Url, 545, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
                                        Write(tagHelperLink.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 23 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\n");
#nullable restore
#line 25 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\nCurrent Date Time: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78f7623fa1e7574e73fc17e42ae2bd9522c50d616485", async() => {
#nullable restore
#line 27 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/Index.cshtml"
                     Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Tests.Model.BuiltInTagHelpers.BuiltInTagHelpersIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
