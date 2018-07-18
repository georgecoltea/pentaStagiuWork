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
            ViewBag.CurrentDateTime = DateTime.Now;
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

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Post post = posts.Find(p => p.Id == id);

            if (post == null)
            {
                return HttpNotFound();
            }

            posts.Remove(post);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Post post = posts.Find(p => p.Id == id);

            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            Post postFromList = posts.Find(p => p.Id == post.Id);
            postFromList.UserId = post.UserId;
            postFromList.IsSticky = post.IsSticky;
            postFromList.Message = post.Message;
            postFromList.Priority = post.Priority;
            postFromList.TimeOfPosting = post.TimeOfPosting;

            return RedirectToAction("Index");
        }

    }
}