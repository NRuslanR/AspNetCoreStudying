using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Mvc.Areas.Files.Model.Uploads
{
    public class FileUpload
    {
        [Display(Name = "Выберите файл:")]
        [Required(ErrorMessage = "Необходимо выбрать файл")]
        public IFormFile FileToUpload { get; set; }
    }
}