using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mvc.Areas.Tests.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "developer.com";
        
        public string MailTo { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            
            string address = $"{MailTo}@{EmailDomain}";
            
            output.Attributes.SetAttribute("href", $"mailto: {address}");
            output.Content.SetContent(address);
        }
    }
}