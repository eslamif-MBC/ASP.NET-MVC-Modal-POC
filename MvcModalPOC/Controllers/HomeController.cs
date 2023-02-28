using MvcModalPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModalPOC.Models;

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
            var vm = new IceCreamVM("3", "Frank", "Baskin Robins", "Chocolatee");
            return View(vm);
        }

        public ActionResult IceCreamPartialView(string id)
        {
            var hi = "hi";
            return PartialView("IceCreamPartialView");
        }
    }
}