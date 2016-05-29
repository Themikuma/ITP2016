using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult MarketPage()
        {
            return View();
        }
        public ActionResult MarketPageSortedByGenre()
        {
            return View();
        }

        public ActionResult CartList()
        {
            return View();
        }

        public ActionResult OrderPage()
        {
            return View();
        }


    }
}