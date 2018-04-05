using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceProject.Models.Requests
{
    public class CreditCardUpdateRequest : CreditCardAddRequest
    {
        public int Id { get; set; }
    }
}