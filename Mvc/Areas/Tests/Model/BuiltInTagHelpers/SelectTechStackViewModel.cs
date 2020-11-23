using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.Areas.Tests.Model.BuiltInTagHelpers
{
    public class SelectTechStackViewModel
    {
        public string Title { get; set; }
        public string CurrentTechStack { get; set; }
        public IList<SelectListItem> TechStackItems { get; set; }
    }
}