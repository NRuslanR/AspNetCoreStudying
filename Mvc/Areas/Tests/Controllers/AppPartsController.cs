using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Mvc.Areas.Tests.Model.AddParts;

namespace Mvc.Areas.Tests.Controllers
{
    [Area("Tests")]
    public class AppPartsController : Controller
    {
        private readonly ApplicationPartManager _applicationPartManager;
        
        public AppPartsController(ApplicationPartManager applicationPartManager)
        {
            _applicationPartManager = applicationPartManager;
        }
        
        public IActionResult Index()
        {
            var controllerFeature = new ControllerFeature();
            
            _applicationPartManager.PopulateFeature(controllerFeature);

            var tagHelperFeature = new TagHelperFeature();
            
            _applicationPartManager.PopulateFeature(tagHelperFeature);
            
            var viewComponentFeature = new ViewComponentFeature();
            
            _applicationPartManager.PopulateFeature(viewComponentFeature);

            return View(
                new AddPartsIndexVIewModel()
                {
                    Controllers = controllerFeature.Controllers,
                    TagHelpers = tagHelperFeature.TagHelpers,
                    ViewComponents = viewComponentFeature.ViewComponents
                }
            );
        }
    }
}