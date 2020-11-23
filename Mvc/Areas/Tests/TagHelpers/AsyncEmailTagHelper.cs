using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mvc.Areas.Tests.TagHelpers
{
    public class AsyncEmailTagHelper : TagHelper
    {
        public const string EmailDomain = "developer.com";
        
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var address = $"{(await output.GetChildContentAsync()).GetContent()}@{EmailDomain}";
            
            output.Attributes.SetAttribute("href", $"mailto: {address}");
            output.Content.SetContent(address);
        }
    }
}