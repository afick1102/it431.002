using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IT431Site.DAL;
using IT431Site.Models;

namespace IT431Site.Controllers
{
    public class ReservationsController : Controller
    {
        private SiteDataContext1 db = new SiteDataContext1();

        // GET: Reservations
        public ActionResult Index()
        {
            return View(db.Reservations.ToList());
        }

        // GET: Reservations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            ViewBag.LocationID = new SelectList(db.Locations, "Id", "LocationName");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerName,CustomerPhone,CustomerEmail,LocationID,StartDate,EndDate,TravelReason,AdultNum,ChildrenNum,Request")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                ViewBag.LocationID = new SelectList(db.Locations, "Id", "LocationName", reservation.LocationID);
                /*Location matchingLocation = db.Locations.Where(cm => cm.Id.ToString().CompareTo(reservation.LocationID.ToString())==0).FirstOrDefault();
                if(matchingLocation != null)
                {
                    DateTime date1 = location.DateOpen;
                    DateTime date2 = location.DateClosed;
                    DateTime date3 = reservation.StartDate;
                    DateTime date4 = reservation.EndDate;

                    int result1 = DateTime.Compare(date3, date1);
                    int result3 = DateTime.Compare(date4, date2);
                    {
                        if (result1 < 0)
                        {
                            ModelState.AddModelError("StartDate", "Location is not available for the date specified.");
                            return View(reservation);
                        }

                        if (result1 >= 0)
                        {
                            int result2 = DateTime.Compare(date3, date2);
                            if (result2 > 0)
                            {
                                ModelState.AddModelError("StartDate", "Location is not available for the date specified.");
                                return View(reservation);
                            }
                        }
                        else if(result3 > 0)
                        {
                            ModelState.AddModelError("EndDate", "Location is not avail");
                        }
                    }
                }*/
                db.Reservations.Add(reservation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocationID = new SelectList(db.Locations, "Id", "LocationName", reservation.LocationID);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerName,CustomerPhone,CustomerEmail,LocationID,StartDate,EndDate,TravelReason,AdultNum,ChildrenNum,Request")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                ViewBag.LocationID = new SelectList(db.Locations, "Id", "LocationName", reservation.LocationID);
                db.Entry(reservation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return HttpNotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            db.Reservations.Remove(reservation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
