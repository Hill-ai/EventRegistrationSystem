using System.Collections.Generic;

namespace EventRegistrationSystem.Models.ViewModels
{
    public class BasicEmployeeCompanyGroup
    {
        public string CompanyName { get; set; }

        public List<ApplicationUser> BasicEmployees { get; set; }
    }
}