using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mvc.Model.Trees;
using System.Threading.Tasks;

namespace Mvc.Controllers.Trees
{
    public class TreesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View(
                new TreesIndexViewModel(
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