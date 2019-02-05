using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using Microsoft.AspNet.Identity;

namespace EventRegistrationSystem.Controllers
{
    //[Authorize(Roles = "ADMIN")]
    public class VolunteerEventsController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Events
        public ActionResult Index(int? tableOrderBy)
        {
            using (var db = new ApplicationDbContext())
            {
                var volunteerEventsList = db.VolunteerEvents.ToList();

                if (tableOrderBy == 1)
                {
                    //var volunteerEventsList = db.VolunteerEvents.Where(c => c.EventDate.Month == DateTime.Today.Month).OrderBy(d => d.EventDate).ToList();

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.EventName).ToList();
                }

                if (tableOrderBy == 2)
                {

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.EventDate).ToList();

                }

                if (tableOrderBy == 3)
                {

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.EventDetails).ToList();

                }

                if (tableOrderBy == 4)
                {

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.NonProfitID).ToList();

                }

                if (tableOrderBy == 5)
                {

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.Company).ToList();

                }

                return View(volunteerEventsList);


                //return View(db.VolunteerEvents.Where(c => c.EventDate.Month == month).ToList());

            }
        }

        public JsonResult GetEvents()
        {
            using (var db = new ApplicationDbContext())
            {
                var events = db.VolunteerEvents.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {

            using (var db = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                VolunteerEvent @event = db.VolunteerEvents.Find(id);
                if (@event == null)
                {
                    return HttpNotFound();
                }
                return View(@event);
            }
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id)
        {

            int eventId = id;
            var identityUserId = User.Identity.GetUserId();

            UsersVolunteerEvent tempUsersVolunteerEvent = new UsersVolunteerEvent();
            tempUsersVolunteerEvent.UserId = identityUserId;
            tempUsersVolunteerEvent.VolunteerEventId = eventId;



            using (var db = new ApplicationDbContext())
            {


                //VolunteerEvent @event = db.VolunteerEvents.Find(id);
                //db.VolunteerEvents.Remove(@event);



                db.UsersVolunteerEvents.Add(@tempUsersVolunteerEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }



        //TODO: protect this method specifically, not the whole controller 
        public ActionResult Create()
        {
            using (var db = new ApplicationDbContext())
            {
                var existingNonprofits = db.NonProfits.ToList();

                ViewBag.ExistingNonprofits = existingNonprofits;

                return View();
            }
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,Company,NonProfit,EventTime,RestrictedByCompany,EventLocked,EventHidden,EventCapacity,EventName,EventDescription,EventDate,EventStartTime,EventEndTime,EventDetails,EventInterest,EventFiles,EventTotalTime,NonProfitID")] VolunteerEvent @event)
        {
            using (var db = new ApplicationDbContext())
            {
                if (ModelState.IsValid)
                {
                    db.VolunteerEvents.Add(@event);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(@event);
            }
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            using (var db = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                VolunteerEvent @event = db.VolunteerEvents.Find(id);
                if (@event == null)
                {
                    return HttpNotFound();
                }
                return View(@event);
            }
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,Company,NonProfit,EventTime,RestrictedByCompany,EventLocked,EventHidden,EventCapacity,EventName,EventDescription,EventDate,EventStartTime,EventEndTime,EventDetails,EventInterest,EventFiles,EventTotalTime,NonProfitID")] VolunteerEvent @event)
        {
            using (var db = new ApplicationDbContext())
            {
                if (ModelState.IsValid)
                {
                    db.Entry(@event).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(@event);

            }

        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            using (var db = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                VolunteerEvent @event = db.VolunteerEvents.Find(id);
                if (@event == null)
                {
                    return HttpNotFound();
                }
                return View(@event);
            }
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            using (var db = new ApplicationDbContext())
            {
                VolunteerEvent @event = db.VolunteerEvents.Find(id);
                db.VolunteerEvents.Remove(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        protected override void Dispose(bool disposing)
        {
            using (var db = new ApplicationDbContext())
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }
        }
    }
}
