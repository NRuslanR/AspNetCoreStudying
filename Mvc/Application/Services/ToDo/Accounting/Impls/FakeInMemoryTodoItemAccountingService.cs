using System;
using System.Threading.Tasks;
using Mvc.Application.Services.ToDo.Accounting.Dtos;
using System.Collections.Generic;

namespace Mvc.Application.Services.ToDo.Accounting.Impls
{
    public class FakeInMemoryTodoItemAccountingService : IToDoItemAccountingService
    {
        private List<ToDoItem> _todoItems;

        public FakeInMemoryTodoItemAccountingService()
        {
            _todoItems =
                new List<ToDoItem>(
                    new ToDoItem[]
                    {
                        new ToDoItem(1, "Make a picture", 5, false),
                        new ToDoItem(2, "Do work", priority: 1, true),
                        new ToDoItem(3, "Do stretching", 2, false),
                    }
                );
        }
        
        public async Task<IEnumerable<ToDoItem>> FindAll()
        {
            return _todoItems;
        }

        public async Task<ToDoItem> FindById(int id)
        {
            return _todoItems.Find(t => t.Id == id);
        }

        public async Task Add(ToDoItem toDoItem)
        {
            ThrowIfTodoItemExists(toDoItem.Id);
            
            _todoItems.Add(toDoItem);
        }

        public async Task Update(ToDoItem toDoItem)
        {
            ThrowIfTodoItemNotExists(toDoItem.Id);

            _todoItems[_todoItems.IndexOf(toDoItem)] = toDoItem;
        }

        public async Task Remove(int id)
        {
            _todoItems.Remove(new ToDoItem() {Id = id});
        }

        private async Task ThrowIfTodoItemExists(int id)
        {
            if (await IsExists(id))
                throw new Exception($"TodoItem {id} is exists");
        }

        private async Task ThrowIfTodoItemNotExists(int id)
        {
            if (!(await IsExists(id)))
                throw new Exception($"TodoItem {id} is not exists");
        }
        private async Task<bool> IsExists(int id)
        {
            return (await FindById(id)) != null;
        }
    }
}