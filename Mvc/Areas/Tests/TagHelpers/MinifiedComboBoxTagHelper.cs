using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Hosting;

namespace Mvc.Areas.Tests.TagHelpers
{
    public class MinifiedComboBoxTagHelper : PartialTagHelper
    {
        private readonly IHostEnvironment _environment;
        
        public MinifiedComboBoxTagHelper(
            ICompositeViewEngine viewEngine, 
            IViewBufferScope viewBufferScope,
            IHostEnvironment environment
            ) :
            base(viewEngine, viewBufferScope)
        {
            _environment = environment;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (_environment.IsProduction())
                Name += ".min";

            base.ProcessAsync(context, output);
        }
    }
}