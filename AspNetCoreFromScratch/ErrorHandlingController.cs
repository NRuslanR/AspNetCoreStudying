using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFromScratch
{
    public class ErrorHandlingController : Controller
    {
        public IActionResult Index()
        {
            var pathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            
            return View(
                new ErrorViewModel()
                {
                    Message = $"At the path {pathFeature.Path} the following error occurred: {pathFeature.Error.Message}"
                });
        }
    }
}