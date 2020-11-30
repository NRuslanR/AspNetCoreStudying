using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Mvc.Areas.Files.Model.Uploads
{
    public class MultipleFilesUpload
    {
        [Display(Name = "Выберите файлы:")]
        [Required(ErrorMessage = "Необходимо выбрать файлы")]
        public IEnumerable<IFormFile> FilesToUpload { get; set; }
    }
}