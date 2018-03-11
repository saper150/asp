using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parser;

namespace RssCore.Controllers
{
    public class RssController : Controller
    {
        public IActionResult Index()
        {
            return View(RssParser.GetRss());
        }
    }
}