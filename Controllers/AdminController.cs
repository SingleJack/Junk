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

        public ActionResult Create()
        {
            return View("AdminForm");
        }

        public ActionResult Edit(int id)
        {
            AdminDAO adminDAO = new AdminDAO();
            AdminModel user = adminDAO.FetchOne(id);
            return View("AdminForm", user);
        }

        public ActionResult Delete(int id)
        {
            AdminDAO adminDAO = new AdminDAO();
            adminDAO.Delete(id);
            List<AdminModel> users = adminDAO.FetchAll();
            return View("Index", users);
        }

        public ActionResult ProcessCreate(AdminModel adminModel)
        {
            //Save to database.
            AdminDAO adminDAO = new AdminDAO();

            adminDAO.CreateOrUpdate(adminModel);

            return View("Details", adminModel);
        }

        public ActionResult SearchForm()
        {
            return View("../SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            AdminDAO adminDAO = new AdminDAO();

            List<AdminModel> searchResults = adminDAO.SearchForName(searchPhrase);
            return View("Index", searchResults);
        }
    }
}