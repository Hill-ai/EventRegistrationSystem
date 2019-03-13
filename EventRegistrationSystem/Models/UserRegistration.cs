using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EventRegistrationSystem.Models
{
    public class UserRegistration
    {
        //TODO DAVID: constructor for DateCreated - default to DateTime.Now
        
        public int UserRegistrationID { get; set; }

        public int CompanyContractID { get; set; }

        //TODO DAVID: change to UserId because that's what it's representing
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsActive { get; set; } = true;

    }
}