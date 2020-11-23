using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mvc.Areas.Tests.TagHelpers
{
    
    //[HtmlTargetElement("span")]
    [HtmlTargetElement("span", Attributes = "bold")]
    public class BoldTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("bold");
            output.PreContent.SetHtmlContent("<strong>");
            output.PostContent.SetHtmlContent("</strong>");
        }
    }
}