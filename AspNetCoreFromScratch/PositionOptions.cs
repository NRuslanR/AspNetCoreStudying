using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace AspNetCoreFromScratch
{
    public class PositionOptions
    {
        [StringLength(11, MinimumLength = 4, ErrorMessage = "Title Length is not valid")]
        public string Title { get; set; }
        
        [RegularExpression(@"[^\d\W]+ [^\d\W]+", ErrorMessage = "Name is not valid")]
        public string Name { get; set; }
    }
}