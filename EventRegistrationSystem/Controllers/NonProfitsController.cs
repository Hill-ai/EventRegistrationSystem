using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class NonProfitsController : Controller
    {
        
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NonProfits
        public ActionResult Index()
        {
            return View(db.NonProfits.ToList());
        }

        // GET: NonProfits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonProfit nonProfit = db.NonProfits.Find(id);
            if (nonProfit == null)
            {
                return HttpNotFound();
            }
            return View(nonProfit);
        }

        // GET: NonProfits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NonProfits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NonProfitID,Name,Address,City,Zip,Phone,Email,PrimaryContactName,PrimaryContactPhone,PrimaryContactEmail,WebLink")] NonProfit nonProfit)
        {
            if (ModelState.IsValid)
            {
                db.NonProfits.Add(nonProfit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nonProfit);
        }

        // GET: NonProfits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonProfit nonProfit = db.NonProfits.Find(id);
            if (nonProfit == null)
            {
                return HttpNotFound();
            }
            return View(nonProfit);
        }

        // POST: NonProfits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NonProfitID,Name,Address,City,Zip,Phone,Email,PrimaryContactName,PrimaryContactPhone,PrimaryContactEmail,WebLink")] NonProfit nonProfit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nonProfit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nonProfit);
        }

        // GET: NonProfits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonProfit nonProfit = db.NonProfits.Find(id);
            if (nonProfit == null)
            {
                return HttpNotFound();
            }
            return View(nonProfit);
        }

        // POST: NonProfits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NonProfit nonProfit = db.NonProfits.Find(id);
            db.NonProfits.Remove(nonProfit);
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
