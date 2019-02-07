using System;
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