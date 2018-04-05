using DbConnector.Tools;
using FinanceProject.Interfaces;
using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceProject.Services
{
    public class FileRepositoryService : BaseService, IFileRepositoryService
    {
        public int Insert(FileRepositoryAddRequest model)
        {
            int id = 0;
            Adapter.ExecuteQuery("dbo.FileRepository_Insert",
                new[]
                {
                    SqlDbParameter.Instance.BuildParameter("@FilePathName", model.FilePathName, System.Data.SqlDbType.NVarChar, 256),
                    SqlDbParameter.Instance.BuildParameter("@Id", 0, System.Data.SqlDbType.Int, paramDirection: System.Data.ParameterDirection.Output)
                },
                (parameters =>
                {
                    id = parameters.GetParmValue<int>("@Id");
                }
                ));
                return id;
        }

    }
}