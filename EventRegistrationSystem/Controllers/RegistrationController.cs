using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            var isAdmin = User.IsInRole("ADMIN");
            if (isAdmin)
            {
                using (var db = new ApplicationDbContext())
                {
                    var companies = db.Companies.ToList();

                    var contracts = db.CompanyContracts.ToList();

                    var query =
                        from c in db.Companies
                        join cc in db.CompanyContracts
                            on c.CompanyID equals cc.CompanyID into j1
                        from j2 in j1.DefaultIfEmpty()
                        group j2 by c
                        into grouped
                        select new CompanyAndContracts
                        {
                            Company = grouped.Key,
                            CompanyContracts = grouped.ToList()
                        };

                    var listOfCompaniesAndTheirContracts = query.ToList();
                    
                    return View(listOfCompaniesAndTheirContracts);
                }
                
            }

            return View("../Account/UnAuthorizedRegister");
        }

        public class CompanyAndContracts
        {
            public Company Company { get; set; }

            public IEnumerable<CompanyContract> CompanyContracts { get; set; } = new List<CompanyContract>();

            public CompanyContract CurrentContract
            {
                get
                {
                    var contracts = CompanyContracts.Where(x => x != null).ToList();

                    if (!contracts.Any()) return null;

                    var activeContracts = contracts.Where(c => c.IsActive).ToList();

                    if (activeContracts.Count() > 1) 
                        throw new Exception("Company can not have more than one active contract");

                    return activeContracts.SingleOrDefault();
                }
            }

            public bool HasActiveContract => CurrentContract != null;
        }
    }
}