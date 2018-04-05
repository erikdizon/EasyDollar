using FinanceProject.Interfaces;
using FinanceProject.Models;
using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanceProject.Controllers.Api
{
    [RoutePrefix("api/CreditCards")]
    public class CreditCardController : ApiController
    {
        ICreditCardService _creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [Route(), HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                IEnumerable<CreditCard> creditCards = _creditCardService.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, creditCards);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("{id:int}"), HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                CreditCard creditCard = _creditCardService.SelectById(id);
                return Request.CreateResponse(HttpStatusCode.OK, creditCard);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route(), HttpPost]
        public HttpResponseMessage Post(CreditCardAddRequest model)
        {
            try
            {
                int id = _creditCardService.Insert(model);
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage Put(CreditCardUpdateRequest model)
        {
            try
            {
                _creditCardService.Update(model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("{id:int}"), HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                _creditCardService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
