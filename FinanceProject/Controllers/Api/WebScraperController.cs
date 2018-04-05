using FinanceProject.Interfaces;
using FinanceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanceProject.Controllers.Api
{
    [RoutePrefix("api/WebScrapes")]
    public class WebScraperController : ApiController
    {
        IWebScraperService _webScraperService;

        public WebScraperController(IWebScraperService webScraperService)
        {
            _webScraperService = webScraperService;
        }

        [Route("CashBack"), HttpGet]

        public HttpResponseMessage GetCashBackScrapes()
        {
            try
            {
                IEnumerable<CardScrape> cashBackScrapes = _webScraperService.CashBackScrape();
                return Request.CreateResponse(HttpStatusCode.OK, cashBackScrapes);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("Travel"), HttpGet]

        public HttpResponseMessage GetTravelScrapes()
        {
            try
            {
                IEnumerable<CardScrape> travelScrapes = _webScraperService.TravelScrape();
                return Request.CreateResponse(HttpStatusCode.OK, travelScrapes);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("BalanceTransfer"), HttpGet]

        public HttpResponseMessage GetBalanceTransferScrapes()
        {
            try
            {
                IEnumerable<CardScrape> balanceTransferScrapes = _webScraperService.BalanceTransferScrape();
                return Request.CreateResponse(HttpStatusCode.OK, balanceTransferScrapes);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
