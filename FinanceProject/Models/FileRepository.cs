using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceProject.Models
{
    public class FileRepository
    {
        public int Id { get; set; }

        public string FilePathName { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}