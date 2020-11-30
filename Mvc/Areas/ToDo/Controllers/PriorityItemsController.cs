using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Application.Services.ToDo.Accounting;

namespace Mvc.Areas.ToDo.Controllers
{
    [Area("ToDo")]
    public class PriorityItemsController : Controller
    {
        private readonly IToDoItemAccountingService _toDoItemAccountingService;

        public PriorityItemsController(IToDoItemAccountingService toDoItemAccountingService)
        {
            _toDoItemAccountingService = toDoItemAccountingService;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            return View(await _toDoItemAccountingService.FindAll());
        }
    }
}