using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Mvc.Areas.Tests.Controllers;

namespace Mvc.Areas.Tests.Filters
{
    public class ActionCallInfoFilter : ActionFilterAttribute
    {
        private ILogger<FiltersController> _logger;
        
        public ActionCallInfoFilter(ILogger<FiltersController> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            
            context.HttpContext.Response.Headers.Add("ActionCall", $"ActionValue ({DateTime.Now})");
            
            _logger.LogInformation($"Action Filter raise at path {context.HttpContext.Request.Path} and ${DateTime.Now}");
        }
    }
}