using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminTestController : Controller
    {
        // GET: AdminTest
        public bool Index()
        {
            var isInRole= User.IsInRole("ADMIN");
            return isInRole;
        }

        public string TokenTest()
        {
            var token = ConfigurationManager.AppSettings["RegisterToken"];
            var actionURL = Url.Action("Register", "Account", null, Request.Url.Scheme);
            var fullURL = string.Format("{0}?token={1}", actionURL, token);
            return fullURL;
        }
    }
}