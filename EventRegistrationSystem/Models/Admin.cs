using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    // This admin model is a placeholder. The plan is to implement 
    // company creation functionality first, without worrying about
    // who or what user/user with specific userRole creates these companies.
    public class Admin
    {
        public int AdminID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}