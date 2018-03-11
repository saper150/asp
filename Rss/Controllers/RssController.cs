using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rss.Controllers
{
    public class RssController : Controller
    {
        // GET: Rss
        public ActionResult Index()
        {
            return View(RssParser.GetRss());
        }
    }
}