#pragma checksum "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Views/Trees/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d354ebd9d6c1be77580b93cf89995fbf2a0894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trees_index), @"mvc.1.0.view", @"/Views/Trees/index.cshtml")]
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
#line 1 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Views/Trees/index.cshtml"
using Mvc.Model.Trees;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d354ebd9d6c1be77580b93cf89995fbf2a0894", @"/Views/Trees/index.cshtml")]
    public class Views_Trees_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TreesIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Views/Trees/index.cshtml"
  
    ViewData["title"] = "Trees - Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Views/Trees/index.cshtml"
Write(await Html.PartialAsync("Partials/_TreeList", Model.TreeList));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TreesIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591