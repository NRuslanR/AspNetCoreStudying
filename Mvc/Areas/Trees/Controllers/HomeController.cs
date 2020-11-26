using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Trees.Model.Common;
using Mvc.Areas.Trees.Model.Home;
using System.Threading.Tasks;

namespace Mvc.Areas.Trees.Controllers
{
    [Area("Trees")]
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(
                new HomeIndexViewModel(
                    new TreeListViewModel(
                        new TreeViewModel[]
                        {
                            new TreeViewModel()
                            {
                                Id = 1,
                                Name = "Oak",
                                GrowthLocation = "Russia"
                            },
                            new TreeViewModel()
                            {
                                Id = 2,
                                Name = "Stump",
                                GrowthLocation = "Usa, Arizona"
                            },
                            new TreeViewModel()
                            {
                                Id = 3,
                                Name = "Aspen",
                                GrowthLocation = "Russia, Moscow"
                            }
                        })
                    )
                );
        }

        public IActionResult Test(int treeId)
        {
            return Ok($"TreeId is {treeId}");
        }
    }
}