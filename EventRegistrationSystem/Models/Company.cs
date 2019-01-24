using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EventRegistrationSystem.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Please enter a company name")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]

        [Required(ErrorMessage = "Please enter a company address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a company phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an email address for the company")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a primary contact name for the company")]
        public string PrimaryContactName { get; set; }

        [Required(ErrorMessage = "Please enter a primary contact phone number for the company")]
        public string PrimaryContactPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the primary contact person's email")]
        public string PrimaryContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter a link to the company's website")]
        public string CompanyWebLink { get; set; }
    }

}