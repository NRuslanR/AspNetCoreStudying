#pragma checksum "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e3bac8d386d1eef89601a26b280ad2de35ec641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tests_Views_BuiltInTagHelpers_SavedInput), @"mvc.1.0.view", @"/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml")]
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
#nullable restore
#line 2 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/_ViewImports.cshtml"
using Mvc.Areas.Files.Model.Uploads;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/_ViewImports.cshtml"
using Mvc.Application.Services.ToDo.Accounting.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e3bac8d386d1eef89601a26b280ad2de35ec641", @"/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31825da461a13a77d4fd52f616967388bbc7c3cf", @"/_ViewImports.cshtml")]
    public class Areas_Tests_Views_BuiltInTagHelpers_SavedInput : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mvc.Areas.Tests.Model.BuiltInTagHelpers.InputTodoItemsViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
  
    ViewData["Title"] = "Built-In Tag Helpers - Saved Input";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("StylesSection", async() => {
                WriteLiteral("\n    <style>\n        table \n        {\n            border-collapse: collapse;\n        }\n        \n        th, td\n        {\n            border: 1px solid black;\n        }\n    </style>\n");
            }
            );
            WriteLiteral("<h1>Ваши задания:</h1>\n<table>\n    <thead>\n    <tr>\n        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e3bac8d386d1eef89601a26b280ad2de35ec6414078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TodoItems[0].Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\n        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e3bac8d386d1eef89601a26b280ad2de35ec6415545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TodoItems[0].IsDone);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 30 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
     foreach (var todoItem in Model.TodoItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 33 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
           Write(todoItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
            Write(todoItem.IsDone ? "Да" : "Нет");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 36 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        Кол-во заданий: ");
#nullable restore
#line 39 "/home/ruslan/RiderProjects/AspNetCoreFromScratch/Mvc/Areas/Tests/Views/BuiltInTagHelpers/SavedInput.cshtml"
                   Write(Model.TodoItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tfoot>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mvc.Areas.Tests.Model.BuiltInTagHelpers.InputTodoItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
