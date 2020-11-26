using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace Mvc.Areas.Tests.Filters
{
    public class AddHeader : ResultFilterAttribute
    {
        private string _name;
        private string[] _values;

        public AddHeader(string name, string[] values)
        {
            _name = name;
            _values = values;
        }
        
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(
                _name,
                new StringValues(_values.Concat(new string[] {DateTime.Now.ToString()}).ToArray())
            );
            
            base.OnResultExecuting(context);
        }
    }
}