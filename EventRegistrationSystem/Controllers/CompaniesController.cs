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
    public class CompaniesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Companies
        public ActionResult Index()
        {
            return View(db.Companies.ToList());
        }

        // GET: Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink,IsActive")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(company);
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink,IsActive")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
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

/*
 * This is the old code for the controller. Before I re-scafolded the controller/views to accomodate the newly added "isActive" attribute to the Company table/model. Surprisingly, or not surprisingly, the new code works out of the box.
 * 
 * 
 * 
 * 
 * 
 * using System;
using System.Linq;
using System.Net;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using Microsoft.AspNet.Identity;

namespace EventRegistrationSystem.Controllers
{

    public class CompaniesController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private ICompanyRepository repository;

        public CompaniesController(ICompanyRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var companies = dbContext.Companies.ToList();
                return View(companies);
            }
        }

        public ActionResult Details(int? id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Company @company = dbContext.Companies.Find(id);
                if (@company == null)
                {
                    return HttpNotFound();
                }
                return View(company);
            }
        }

        public ActionResult Edit(int? id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Company @company = dbContext.Companies.Find(id);
                if (@company == null)
                {
                    return HttpNotFound();
                }
                return View(company);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMIN")]
        public ActionResult Edit([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink")] Company company)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                if (ModelState.IsValid)
                {
                    dbContext.Entry(company).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    TempData["message"] = string.Format("{0} has been saved", company.Name);
                    return RedirectToAction("Index");
                }
                // there is something wrong with the data values
                return View(@company);
            } 
        }    
        

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
//        [Authorize(Roles = "ADMIN")]
        public ActionResult Create(Company company)
        {
            try
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.Companies.Add(company);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
//                repository.SaveCompany(company);
//                TempData["message"] = string.Format("{0} has been saved", company.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(company);
            }
        }

        public ActionResult Delete(int? id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Company @company = dbContext.Companies.Find(id);
                if (@company == null)
                {
                    return HttpNotFound();
                }
                return View(@company);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMIN")]
        public ActionResult Delete(int id)
        {

            using (var dbContext = new ApplicationDbContext())
            {
                Company @company = dbContext.Companies.Find(id);
                dbContext.Companies.Remove(@company);
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
        }



    }
}
 */
