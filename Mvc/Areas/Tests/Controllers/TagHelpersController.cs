using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Tests.Model.TagHelpers;

namespace Mvc.Areas.Tests.Controllers
{
    [Area("Tests")]
    public class TagHelpersController : Controller
    {
        // GET
        public IActionResult Email()
        {
            return View();
        }

        public IActionResult Bold()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Condition([FromQuery] bool visible = true)
        {
            return View(new TagHelperConditionViewModel() {ElementVisible = visible});
        }
    }
}