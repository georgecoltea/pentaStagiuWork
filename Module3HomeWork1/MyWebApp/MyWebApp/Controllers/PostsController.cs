using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class PostsController : Controller
    {
        public static List<Post> posts = new List<Post>();
        public static int PostId = 0;
        // GET: Posts

        public ActionResult Index()
        {
            return View(posts);
        }

        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Post post)
        {
            if(post == null)
            {
                HttpNotFound();
            }

            PostId++;
            post.Id = PostId;
            posts.Add(post);

            return RedirectToAction("Details");

        }

        [HttpGet]

        public ActionResult Details()
        {
            int lastPost = posts.Count;
            Post post = posts.Find(p => p.Id == lastPost);
            return View(post);
        }

    }
}