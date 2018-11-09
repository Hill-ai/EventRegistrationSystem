using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Abstract;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.DataAccess;

namespace EventRegistrationSystem.Controllers
{
   
    public class CompanyController : Controller
    {
        private ICompanyRepository repository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            this.repository = companyRepository;
        }
        public ViewResult List()
        {
            return View(repository.Companies);
        }
    }
    /*  
     public class CompanyController : Controller
     {
         [HttpPost]
         public ActionResult Create(Company @company)      
         {
             using (var dbContext = new CompaniesDbContext())
             {
                 //add to the in memory collection
                 dbContext.Companies.Add(@company);

                 //persist these data changes to the db
                 dbContext.SaveChanges();

                 //go to List action method to start new process
                 return RedirectToAction("List");
             }
         }

         public ActionResult List()
         {
             using (var dbContext = new CompaniesDbContext())
             {
                 var companyList = dbContext.Companies.ToList();
                 return View(companyList);
             }
         }
     }
     **/
}