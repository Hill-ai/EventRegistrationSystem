using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

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
        public ActionResult Index()
        {
            return View(repository.Companies);
            //var companyList = db.Companies.ToList();
            //return View(companyList);

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

        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink")] Company newCompany)
        {
            if (ModelState.IsValid)
            {
                repository.AddToCompanies(newCompany);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newCompany);
        }

        // GET: Companies/Edit/5
        public ViewResult Edit(int? companyID)
        {
            if (companyID == null)
            {
                // return HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = repository.Companies.FirstOrDefault(c => c.CompanyID == companyID);
            if (company == null)
            {
                // return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = await db.Companies.FindAsync(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Company company = await db.Companies.FindAsync(id);
            db.Companies.Remove(company);
            await db.SaveChangesAsync();
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
/**
  [HttpPost]
 public ActionResult Create(Company @company)      
 {
     using (var dbContext = new ApplicationDbContext())
     {
         if (ModelState.IsValid)
        {
            //add to the in memory collection
            dbContext.AddToCompanies(@company);
            //persist these data changes to the db
            dbContext.SaveChanges();
            //go to List action method to start new process
            return RedirectToAction("List");
        }
         else
        {
            var companydbContext.Companies.ToList();
            return View(@company);
        }               
     }
 }

 public ActionResult List()
 {
     using (var dbContext = new ApplicationDbContext())
     {
         var companyList = dbContext.Companies.ToList();
         return View(companyList);
     }
 }
 **/
