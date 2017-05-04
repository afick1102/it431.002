using IT431Site.DAL;
using IT431Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT431Site.Controllers
{
    public class HomeController : Controller
    {
        private SiteDataContext1 db = new SiteDataContext1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Locations()
        {
            return View(db.Locations.ToList());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPost([Bind(Include = "Id,Title,Author,Content,Date")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.Date = DateTime.Now;
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("About");
            }

            return RedirectToAction("About");
        }
    }
}