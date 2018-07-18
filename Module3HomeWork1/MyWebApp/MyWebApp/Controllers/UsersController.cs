using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class UsersController : Controller
    {
        public static List<User> users = new List<User>();
        public static int Id = 0;

        // GET: Users
        public ActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            User user = users.Find(u => u.Id == id);
            if(user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            Id++;
            user.Id = Id;
            users.Add(user);
            return RedirectToAction("Index");
        }
    }
}