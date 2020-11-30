using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Areas.Files.Model.Uploads;
using System.Linq;
using System.Collections.Generic;

namespace Mvc.Areas.Files.Controllers
{
    [Area("Files")]
    public class UploadsController : Controller
    {
        [HttpGet]
        public IActionResult Single()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Single(FileUpload fileUpload)
        {
            if (!ModelState.IsValid)
                return View(fileUpload);

            try
            {
                await using (
                    var stream = 
                        System.IO.File.Create(
                            Path.Combine(
                                Path.GetTempPath(), fileUpload.FileToUpload.FileName
                                )
                            )
                        )
                {
                    await fileUpload.FileToUpload.CopyToAsync(stream);
                }
                
                return Ok(
                    $"File {fileUpload.FileToUpload.FileName} in size {fileUpload.FileToUpload.Length} uploaded !"
                );
            }
            
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Multiple()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Multiple(MultipleFilesUpload multipleFilesUpload)
        {
            if (!ModelState.IsValid)
                return View(multipleFilesUpload);

            var filesToUpload = multipleFilesUpload.FilesToUpload;
            
            MultipleFilesUploadResult result = new MultipleFilesUploadResult();
            
            foreach (var fileToUpload in filesToUpload)
            {
                try
                {
                    await using (
                        var stream =
                            System.IO.File.Create(
                                Path.Combine(
                                    Path.GetTempPath(), fileToUpload.FileName
                                )
                            )
                    )
                    {
                        await fileToUpload.CopyToAsync(stream);
                    }

                    result.UploadedFiles.Add(fileToUpload.FileName);
                }

                catch (Exception ex)
                {
                    result.NotUploadedFiles.Add(
                        new KeyValuePair<string, string>(
                                fileToUpload.FileName, ex.Message
                                )
                        );
                }
            }

            result.TotalFileUploadedSize =
                filesToUpload.Where(
                    f => result.UploadedFiles.Contains(f.FileName)
                ).Sum(f => f.Length);

            return View("MultipleResult", result);
        }
    }
}