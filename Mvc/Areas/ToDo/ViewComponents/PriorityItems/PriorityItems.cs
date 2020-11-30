using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Application.Services.ToDo.Accounting;
using Mvc.Application.Services.ToDo.Accounting.Dtos;

namespace Mvc.Areas.ToDo.ViewComponents.PriorityItems
{
    [ViewComponent(Name = "PriorityItems")]
    public class PriorityItems : ViewComponent
    {
        private readonly IToDoItemAccountingService _toDoItemAccountingService;

        public PriorityItems(IToDoItemAccountingService toDoItemAccountingService)
        {
            _toDoItemAccountingService = toDoItemAccountingService;
        }
        
        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            string viewName =
                maxPriority > 3 && isDone == false ? "PVC" : "Default";

            return View(viewName, await GetTodoItemsAsyncBy(maxPriority, isDone));
        }

        private async Task<IEnumerable<ToDoItem>> GetTodoItemsAsyncBy(int maxPriority, bool isDone)
        {
            return
                from todoItem in await _toDoItemAccountingService.FindAll()
                where todoItem.IsDone == isDone && todoItem.Priority <= maxPriority
                select todoItem;
        }
    }
}