using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Areas.Tests.Model.BuiltInTagHelpers
{
    public class TodoItemViewModel
    {
        [Display(Name = "Наименование пункта")]
        public string Name { get; set; }
        
        [Display(Name = "Выполнен")]
        public bool IsDone { get; set; }
    }
    public class InputTodoItemsViewModel
    {
        public IList<TodoItemViewModel> TodoItems { get; set; }
    }
}