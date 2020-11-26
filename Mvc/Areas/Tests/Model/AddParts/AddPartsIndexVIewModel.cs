using System.Collections.Generic;
using System.Reflection;

namespace Mvc.Areas.Tests.Model.AddParts
{
    public class AddPartsIndexVIewModel
    {
        public IEnumerable<TypeInfo> Controllers { get; set; }
        public IEnumerable<TypeInfo> TagHelpers { get; set; }
        public IEnumerable<TypeInfo> ViewComponents { get; set; }
    }
}