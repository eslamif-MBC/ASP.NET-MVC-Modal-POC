using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModalPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult JavaScriptWay()
        {
            return View();
        }

        public ActionResult MvcWay()
        {
            return View();
        }
    }
}