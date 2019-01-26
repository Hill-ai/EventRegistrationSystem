using System;
using System.Linq;
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

        public ViewResult Index()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var companies = dbContext.Companies.ToList();

                return View(companies);
            }
        }

        public ViewResult Details(int id)
        {
            Company company = repository.Companies.FirstOrDefault(c => c.CompanyID == id);
            return View(company);
        }

        public ActionResult Edit(int id)
        {
//            Company company = repository.Companies.FirstOrDefault(c => c.CompanyID == companyID);
            using (var db = new ApplicationDbContext())
            {
                Company company = db.Companies.FirstOrDefault(c => c.CompanyID == id);
                return View(company);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMIN")]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMIN")]
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