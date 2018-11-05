using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Abstract;
using EventRegistrationSystem.Models;

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
}