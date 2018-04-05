using FinanceProject.Interfaces;
using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanceProject.Controllers.Api
{
    [RoutePrefix("api/FileRepositories")]
    public class FileRepositoryController : ApiController
    {
        IFileRepositoryService _fileRepositoryService;

        public FileRepositoryController(IFileRepositoryService fileRepositoryService)
        {
            _fileRepositoryService = fileRepositoryService;
        }

        [Route(), HttpPost]
        public HttpResponseMessage Post(FileRepositoryAddRequest model)
        {
            try
            {
                int id = _fileRepositoryService.Insert(model);
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
