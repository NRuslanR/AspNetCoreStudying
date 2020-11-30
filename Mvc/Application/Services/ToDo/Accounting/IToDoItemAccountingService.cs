using System.Collections.Generic;
using System.Threading.Tasks;
using Mvc.Application.Services.ToDo.Accounting.Dtos;

namespace Mvc.Application.Services.ToDo.Accounting
{
    public interface IToDoItemAccountingService
    {
        Task<IEnumerable<ToDoItem>> FindAll();
        Task<ToDoItem> FindById(int id);
        Task Add(ToDoItem toDoItem);
        Task Update(ToDoItem toDoItem);
        Task Remove(int id);
    }
}