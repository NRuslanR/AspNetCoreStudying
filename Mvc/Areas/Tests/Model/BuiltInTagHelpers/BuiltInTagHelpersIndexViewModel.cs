using System.Collections.Generic;

namespace Mvc.Areas.Tests.Model.BuiltInTagHelpers
{
    public class ActionLink
    {
        public string Url { get; set; }
        public string Content { get; set; }
    }
    
    public class BuiltInTagHelpersIndexViewModel
    {
        public string Header { get; set; }
        public IEnumerable<ActionLink> TagHelperLinks { get; set; }
    }
}