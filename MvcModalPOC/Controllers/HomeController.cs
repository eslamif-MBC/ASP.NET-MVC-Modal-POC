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
            var vm = new IceCreamVM();
            vm.ID = 3;

            return View(vm);
        }

        public ActionResult IceCreamPartialView(int id)
        {
            var vm = new IceCreamVM();
            vm.ID = id;
            vm.FirstName = "Frank";
            vm.Brand = "Baskin Robbins";
            vm.Flavor = "Chocolate";

            return PartialView("IceCreamPartialView", vm);
        }
    }
}