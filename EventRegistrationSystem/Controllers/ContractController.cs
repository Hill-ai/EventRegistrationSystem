using System.Linq;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Controllers
{
    public class ContractController : Controller
    {
        // GET
        public ActionResult ContractsForCompany(int companyId)
        {
            using (var db = new ApplicationDbContext())
            {
                var companyContracts = db.CompanyContracts
                    .Where(c => c.CompanyID == companyId)
                    .ToList();

                var company = db.Companies.SingleOrDefault(i => i.CompanyID == companyId);

                ViewBag.CompanyName = company?.Name;
                ViewBag.CompanyId = companyId;

                return View(companyContracts);
            }
        }

        [HttpGet]
        public ActionResult CreateContract(int companyId)
        {
            using (var db = new ApplicationDbContext())
            {
                var company = db.Companies.SingleOrDefault(i => i.CompanyID == companyId);
                
                ViewBag.CompanyName = company?.Name;
                ViewBag.CompanyId = companyId;
                
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateContract(CompanyContract contract)
        {
            using (var db = new ApplicationDbContext())
            {
                if (!ModelState.IsValid) return RedirectToAction("CreateContract", new
                {
                    companyId = contract.CompanyID
                });

                var companyContracts = db.CompanyContracts.Where(c => c.CompanyID == contract.CompanyID).ToList();

                if (companyContracts.Any())
                {
                    foreach (var companyContract in companyContracts)
                    {
                        companyContract.IsActive = false;
                    }
                }
                
                db.CompanyContracts.Add(contract);
                db.SaveChanges();
                return RedirectToAction("ContractsForCompany",
                    new {companyId = contract.CompanyID});

            }
        }

        [HttpGet]
        public ActionResult Edit(int contractId)
        {
            using (var db = new ApplicationDbContext())
            {
                var contract = db.CompanyContracts.SingleOrDefault(i => i.CompanyContractID == contractId);

                return View(contract);
            }
        }
    }
}