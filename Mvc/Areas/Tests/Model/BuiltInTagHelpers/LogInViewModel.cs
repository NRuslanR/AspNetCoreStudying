using System.ComponentModel.DataAnnotations;

namespace Mvc.Areas.Tests.Model.BuiltInTagHelpers
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Логин обязателен к заполнению")]
        [Display(Name = "Логин")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Пароль обязателен к заполнению")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [RegularExpression("[a-zA-z0-9_]{6,}", ErrorMessage = "Пароль не удовлетворяет требованиям безопасности")]
        public string Password { get; set; }
    }
}