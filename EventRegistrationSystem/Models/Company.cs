using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    public class Company 
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactPhoneNumber { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string CompanyWebLink { get; set; }
    }
}