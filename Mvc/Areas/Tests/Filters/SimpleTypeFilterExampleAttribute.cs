using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Mvc.Areas.Tests.Controllers;

namespace Mvc.Areas.Tests.Filters
{
    public class SimpleTypeFilterExampleAttribute : ExceptionFilterAttribute
    {
        private readonly ILogger<FiltersController> _logger;

        public SimpleTypeFilterExampleAttribute(ILogger<FiltersController> logger)
        {
            _logger = logger;
        }
        
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
            
            context.ExceptionHandled = true;
            
            context.Result = new ContentResult()
            {
                Content = $"<h1>Exception raised:</h1><br><h3>Message: {context.Exception.Message}</h3><br><h3>Stack Trace:{context.Exception.StackTrace}</h3>",
                ContentType = "text/html",
                StatusCode = 500
            };
        }
    }
}