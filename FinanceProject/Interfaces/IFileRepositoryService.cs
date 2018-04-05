using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Interfaces
{
    public interface IFileRepositoryService
    {
        int Insert(FileRepositoryAddRequest model);
    }
}
