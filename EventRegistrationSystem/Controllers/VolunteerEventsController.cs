using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace EventRegistrationSystem.Controllers
{
    //[Authorize(Roles = "ADMIN")]
    public class VolunteerEventsController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;// for sending registration email

        public VolunteerEventsController()
        {

        }

        public VolunteerEventsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            //get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }

            //private set { _userManager = value;  }


            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            private set { _userManager = value; }
        }

     


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

                    volunteerEventsList = db.VolunteerEvents.OrderBy(d => d.NonProfit).ToList();

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
        public ActionResult Details(int? id, string name, string nonProfit)
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

        //trying to register event and send confirmation email
        // POST: Events/Delete/5
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Details(int id)
        {
            int eventId = id;
            int nonProfitId;
            string eventName;
            string eventNonProfit;
            string eventStartTime;
            string eventDate;
            string nonProfitAddress;
            string nonProfitCity;
            string nonProfitPhone;
            string nonProfitEmail;
            string nonProfitContactName;
            string nonProfitContactPhone;
            string nonProfitContactEmail;
            string nonProfitWebLink;
            var identityUserId = User.Identity.GetUserId();
            bool registrationIsSuccesful = false;

            UsersVolunteerEvent tempUsersVolunteerEvent = new UsersVolunteerEvent();
            tempUsersVolunteerEvent.UserId = identityUserId;
            tempUsersVolunteerEvent.VolunteerEventId = eventId;

            using (var db = new ApplicationDbContext())
            {


                //VolunteerEvent @event = db.VolunteerEvents.Find(id);
                //db.VolunteerEvents.Remove(@event);

                

                db.UsersVolunteerEvents.Add(@tempUsersVolunteerEvent);
                db.SaveChanges();
                registrationIsSuccesful = true;
                eventName = db.VolunteerEvents.Find(id).EventName;
                eventNonProfit = db.VolunteerEvents.Find(id).NonProfit;
                eventDate = db.VolunteerEvents.Find(id).EventStartTime.ToShortDateString();
                eventStartTime = db.VolunteerEvents.Find(id).EventStartTime.ToShortTimeString();

                nonProfitId = db.VolunteerEvents.Find(id).NonProfitID;
                nonProfitAddress = db.NonProfits.Find(nonProfitId).Address;
                nonProfitCity = db.NonProfits.Find(nonProfitId).City;
                nonProfitPhone = db.NonProfits.Find(nonProfitId).Phone;
                nonProfitEmail = db.NonProfits.Find(nonProfitId).Email;
                nonProfitContactName = db.NonProfits.Find(nonProfitId).PrimaryContactName;
                nonProfitContactEmail = db.NonProfits.Find(nonProfitId).PrimaryContactEmail;
                nonProfitContactPhone = db.NonProfits.Find(nonProfitId).PrimaryContactPhone;
                nonProfitWebLink = db.NonProfits.Find(nonProfitId).WebLink;



            }

            if (registrationIsSuccesful)
            {
                await UserManager.SendEmailAsync(identityUserId, "Day of Difference Volunteer Event Confirmation" ,"<html>You have succesfully registered for " + eventName + 
                    "<br><br>" + eventName + "is hosted by " + eventNonProfit + ", and is scheduled to start at " + eventStartTime + " on " + eventDate +
                    "<br><br>" + eventNonProfit + " is located at " + nonProfitAddress + ", " + nonProfitCity +
                    
                    "<br><br>For questions about this event, please contact " + nonProfitContactName + " via phone at " +  nonProfitContactPhone +
                    " or via email at " + nonProfitContactEmail + 
                    "<br><br> To contact " + eventNonProfit + ", please call " + nonProfitPhone +
                    " or send an email to " + nonProfitEmail +
                    "<br><br> To find out more about " +  eventNonProfit + ", please visit " + nonProfitWebLink + "</html>");
            }

            return RedirectToAction("EventRegistrationEmailSent", "VolunteerEvents");
        }


        //
        // GET: /VolunteerEvents/EventRegistrationEmailSent
        [AllowAnonymous]
        public ActionResult EventRegistrationEmailSent()
        {
            return View();
        }


        /*
         * working code for saving event registration to DB (no email confirm)
        // POST: Events/Delete/5
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id, ApplicationUserManager userManager)
        {

            //code for saving event registration in db
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
        */


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
