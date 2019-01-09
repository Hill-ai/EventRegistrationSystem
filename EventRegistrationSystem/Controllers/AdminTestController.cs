using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class AdminTestController : Controller
    {
        // GET: AdminTest
        public bool Index()
        {
            var isInRole= User.IsInRole("ADMIN");
            return isInRole;
        }
    }
}