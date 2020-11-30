using System.ComponentModel.DataAnnotations;

namespace Mvc.Application.Services.ToDo.Accounting.Dtos
{
    public class ToDoItem
    {
        public int Id { get; set; }
        
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        
        [Display(Name = "Приоритет")]
        public int Priority { get; set; }
        
        [Display(Name = "Выполнен")]
        public bool IsDone { get; set; }

        public ToDoItem()
        {
            
        }
        public ToDoItem(int id, string name, int priority, bool isDone)
        {
            Id = id;
            Name = name;
            Priority = priority;
            IsDone = isDone;
        }

        public override bool Equals(object? obj) => Equals(obj as ToDoItem);

        public bool Equals(ToDoItem other)
        {
            return other != null && Id == other.Id;
        }
        
    }
}