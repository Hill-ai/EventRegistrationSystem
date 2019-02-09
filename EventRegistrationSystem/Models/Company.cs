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

        [Required]
        [StringLength(50, ErrorMessage = "Company name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Company address cannot be longer than 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "You must provide a phone number for the company")]
        [Display(Name = "Company Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Company Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Primary Contact Person Name")]
        [StringLength(50, ErrorMessage = "The name of this company's primary contact person cannot be longer than 50 characters.")]
        public string PrimaryContactName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number for the primary contact person")]
        [Display(Name = "Primary Contact Person Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PrimaryContactPhoneNumber { get; set; }

        [Display(Name = "Primary Contact Person Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PrimaryContactEmail { get; set; }

        [Url]
        [Display(Name = "Company Url")]
        public string CompanyWebLink { get; set; }

        [Display(Name = "Company Is Active")]
        public bool IsActive { get; set; }

    }
}