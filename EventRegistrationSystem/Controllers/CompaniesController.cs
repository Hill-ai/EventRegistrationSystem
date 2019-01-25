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
    //[Authorize(Roles ="ADMIN")]
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
            return View(repository.Companies);
        }

        public ViewResult Details(int companyId)
        {
            Company company = repository.Companies.FirstOrDefault(c => c.CompanyID == companyId);
            return View(company);
        }

        public ViewResult Edit(int companyID)
        {
            Company company = repository.Companies.FirstOrDefault(c => c.CompanyID == companyID); 
            return View(company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink")] Company company)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCompany(company);
                TempData["message"] = string.Format("{0} has been saved", company.Name);
                return RedirectToAction("Index");
            } else
            {
                // there is something wrong with the data values
                return View(company);
            } 
        }

        public ViewResult Create()
        {
            return View("Create", new Company());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyID,Name,Address,PhoneNumber,Email,PrimaryContactName,PrimaryContactPhoneNumber,PrimaryContactEmail,CompanyWebLink")] Company company)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCompany(company);
                TempData["message"] = string.Format("{0} has been saved", company.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(company);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int companyId)
        {
            Company deletedCompany = repository.DeleteCompany(companyId);
            if (deletedCompany != null)
            {
                TempData["message"] = string.Format("{0} was deleted",
                deletedCompany.Name);
            }
            return RedirectToAction("Index");
        }
    }
}