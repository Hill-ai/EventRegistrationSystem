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

                    return View(companies);
                }
                
            }

            return View("../Account/UnAuthorizedRegister");
        }
    }
}