using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rss.Controllers
{
    public class BalanceController : Controller {

        static int balance;
        public ActionResult Index()
        {
            return View(balance);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Index(int by = 0) {
            balance += by;
            return RedirectToAction("Index");
        }

        public ActionResult LogIn() {
            Session.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string login, string password)
        {
            if (login == "stefan" && password == "123") {
                Session["logedIn"] = true;
                return RedirectToAction("Index");
            }
            return RedirectToAction("LogIn");
        }

    }
}
