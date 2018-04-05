using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinanceProject.Models.Requests
{
    public class FileRepositoryAddRequest
    {
        [Required]
        public string FilePathName { get; set; }
    }
}