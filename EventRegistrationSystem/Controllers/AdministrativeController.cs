using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Models.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace EventRegistrationSystem.Controllers
{
    public class AdministrativeController : Controller
    {
        /// <summary>
        /// If you need to query the AspNetUsers table, please add the following to your controllers
        /// </summary>
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AdministrativeController()
        {
        }
        
        public AdministrativeController(
            ApplicationUserManager userManager,
            ApplicationSignInManager signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public ApplicationSignInManager SignInManager
        {
            get { return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>(); }
            private set { _signInManager = value; }
        }

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            private set { _userManager = value; }
        }
        /// <summary>
        /// End of AspNetUsers code
        /// </summary>
        /// <returns></returns>
        
        
        public ActionResult ViewEmployees()
        {
            //go get employees
            //full name, email, what company
            using (var db = new ApplicationDbContext())
            {
                var emps = UserManager.Users.ToList();
                
                //hack because db context disposing before the view
                var userIds = emps.Select(e => e.Id).ToList();
                //TODO: find out why emps variable didn't instantiate objects
                
                var employees =
                    from e in emps
                    join c in db.Companies
                        on e.CompanyId equals c.CompanyID
                    group e by c.Name
                    into g
                    select new BasicEmployeeCompanyGroup()
                    {
                        CompanyName = g.Key,
                        BasicEmployees = g.ToList()
                    };

                var employeeGroupList = employees.ToList();
                
                return View(employeeGroupList);
            }
        }

        public ActionResult ToggleEmployeeIsActive(string userId)
        {
            using (var db = new ApplicationDbContext())
            {
                var employee = UserManager.Users.SingleOrDefault(u => u.Id == userId);

                var currentActive = employee.IsActive;

                employee.IsActive = !(currentActive);

                UserManager.Update(employee);
                
                return RedirectToAction("ViewEmployees");
            }
        }
    }
}