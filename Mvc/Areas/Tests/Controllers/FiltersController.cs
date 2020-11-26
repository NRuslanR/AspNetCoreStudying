using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Tests.Filters;

namespace Mvc.Areas.Tests.Controllers
{
    [Area("Tests")]
    [AddHeader("TestHeader", new string[] { "TestValue1", "TestValue2"})]
    public class FiltersController : Controller
    {
        // GET
        public IActionResult Result()
        {
            return Content($"{HttpContext.Request.Path}: See Response Headers");
        }

        [ServiceFilter(typeof(ActionCallInfoFilter))]
        public IActionResult SpecificResult()
        {
            return Content($"{HttpContext.Request.Path}: See Response Headers");
        }

        [ShortCircuitingResourceFilter]
        public IActionResult ShortCircuitingByResourceFilter()
        {
            return Content($"Short-Circuiting Resource Filter Testing");
        }

        [TypeFilter(typeof(SimpleTypeFilterExampleAttribute), IsReusable = true)]
        public IActionResult ExceptionFilter()
        {
            throw new Exception("Test Exception Filter Exception");
        }

        [ModelStateActionFilter]
        public IActionResult ModelState(int x, float y)
        {
            return Content("Model State is valid");
        }
    }
}