using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchedulerApp.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Main()
        {
            //return a 'mainview.cshtml' - view maps to the action method name
            return View();
        }

        public ActionResult ErrorMessage()
        {
            //return a 'mainview.cshtml' - view maps to the action method name
            return View();
        }
    }
}