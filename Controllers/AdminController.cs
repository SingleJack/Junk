using SchedulerApp.Data;
using SchedulerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchedulerApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<AdminModel> usersList = new List<AdminModel>();
            AdminDAO adminDAO = new AdminDAO();

            usersList = adminDAO.FetchAll();

            return View("Index", usersList);
        }

        public ActionResult Details(int id)
        {
            AdminDAO adminDAO = new AdminDAO();
            AdminModel user = adminDAO.FetchOne(id);
            return View("Details", user);
        }
    }
}