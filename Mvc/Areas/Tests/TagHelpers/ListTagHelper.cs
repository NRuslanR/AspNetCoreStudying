using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mvc.Areas.Tests.TagHelpers
{
    [HtmlTargetElement("list", TagStructure = TagStructure.WithoutEndTag)]
    public class ListTagHelper : TagHelper
    {
        public IEnumerable<string> Data { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Content.SetHtmlContent(
                string.Concat(from item in Data select $"<li>{item}</li>")
            );
        }
    }
}