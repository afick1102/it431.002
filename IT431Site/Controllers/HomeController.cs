using IT431Site.DAL;
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
    }
}