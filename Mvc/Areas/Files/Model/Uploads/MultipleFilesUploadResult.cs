using System.Collections.Generic;

namespace Mvc.Areas.Files.Model.Uploads
{
    public class MultipleFilesUploadResult
    {
        public long TotalFileUploadedSize { get; set; }
        public IList<string> UploadedFiles { get; set; }
        public IList<KeyValuePair<string, string>> NotUploadedFiles { get; set; }

        public MultipleFilesUploadResult()
        {
            UploadedFiles = new List<string>();
            NotUploadedFiles = new List<KeyValuePair<string, string>>();
        }
    }
}