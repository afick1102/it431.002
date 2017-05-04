using IT431Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT431Site.Controllers
{
    public class BenefitsModelsController : Controller
    {
        // GET: BenefitsModels
        public ActionResult Index()
        {
            var model = new BenefitsModels
            {
                AvailableBenefits = GetBenefits()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(BenefitsModels model)
        {
            if (ModelState.IsValid)
            {
                var benefits = string.Join(",", model.SelectedBenefits);

                return RedirectToAction("Success");
            }
            model.AvailableBenefits = GetBenefits();
            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }

        private IList<SelectListItem> GetBenefits()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem {Text = "Free WiFi", Value = "Free WiFi"},
                new SelectListItem {Text = "Housekeeping", Value = "Housekeeping" },
                new SelectListItem {Text = "24/7 Gym", Value = "24/7 Gym" },
                new SelectListItem {Text = "Outdoor Pool", Value = "Outdoor Pool" },
                new SelectListItem {Text = "Indoor Pool", Value = "Indoor Pool" }
            };
        }
    }
}