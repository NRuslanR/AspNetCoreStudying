#pragma checksum "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/AppParts/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d32e190e61b46c03c0bc7792e77ba59b124de08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tests_Views_AppParts_Index), @"mvc.1.0.view", @"/Areas/Tests/Views/AppParts/Index.cshtml")]
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
#line 1 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d32e190e61b46c03c0bc7792e77ba59b124de08", @"/Areas/Tests/Views/AppParts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1b723f423f1a97d1a961658293c2df24825f25", @"/_ViewImports.cshtml")]
    public class Areas_Tests_Views_AppParts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Tests.Model.AddParts.AddPartsIndexVIewModel>
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
        private global::Mvc.Areas.Tests.TagHelpers.ListTagHelper __Mvc_Areas_Tests_TagHelpers_ListTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/AppParts/Index.cshtml"
  
    ViewData["Title"] = "Application Parts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Controllers:</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d32e190e61b46c03c0bc7792e77ba59b124de083176", async() => {
            }
            );
            __Mvc_Areas_Tests_TagHelpers_ListTagHelper = CreateTagHelper<global::Mvc.Areas.Tests.TagHelpers.ListTagHelper>();
            __tagHelperExecutionContext.Add(__Mvc_Areas_Tests_TagHelpers_ListTagHelper);
#nullable restore
#line 8 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/AppParts/Index.cshtml"
__Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data = Model.Controllers.Select(t => t.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("data", __Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h1>Tag Helpers:</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d32e190e61b46c03c0bc7792e77ba59b124de084520", async() => {
            }
            );
            __Mvc_Areas_Tests_TagHelpers_ListTagHelper = CreateTagHelper<global::Mvc.Areas.Tests.TagHelpers.ListTagHelper>();
            __tagHelperExecutionContext.Add(__Mvc_Areas_Tests_TagHelpers_ListTagHelper);
#nullable restore
#line 10 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/AppParts/Index.cshtml"
__Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data = Model.TagHelpers.Select(t => t.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("data", __Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h1>View Components:</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d32e190e61b46c03c0bc7792e77ba59b124de085868", async() => {
            }
            );
            __Mvc_Areas_Tests_TagHelpers_ListTagHelper = CreateTagHelper<global::Mvc.Areas.Tests.TagHelpers.ListTagHelper>();
            __tagHelperExecutionContext.Add(__Mvc_Areas_Tests_TagHelpers_ListTagHelper);
#nullable restore
#line 12 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/AppParts/Index.cshtml"
__Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data = Model.ViewComponents.Select(t => t.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("data", __Mvc_Areas_Tests_TagHelpers_ListTagHelper.Data, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Tests.Model.AddParts.AddPartsIndexVIewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
