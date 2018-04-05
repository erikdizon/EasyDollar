using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanceProject.Controllers
{
    public class CreditCardsController : Controller
    {
        // GET: CreditCards
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TopCashBack()
        {
            return View();
        }

        public ActionResult TopTravel()
        {
            return View();
        }

        public ActionResult TopBalanceTransfer()
        {
            return View();
        }
    }
}