using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinanceProject.Controllers
{
    public class ProductHighlightsController : Controller
    {
        // GET: ProductHighlights
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductManager()
        {
            return View();
        }

        public ActionResult CreditCards()
        {
            return View();
        }
    }
}