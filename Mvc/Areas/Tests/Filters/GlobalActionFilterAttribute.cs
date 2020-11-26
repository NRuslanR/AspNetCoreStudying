using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace Mvc.Areas.Tests.Filters
{
    public class GlobalActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Add(
                "GlobalActionFilter",
                new StringValues(
                    new string[]
                    {
                        "First Value",
                        "Second Value",
                        "Third Value"
                    }));
        }
    }
}