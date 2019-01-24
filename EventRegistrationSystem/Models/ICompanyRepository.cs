using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Models
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }

        void SaveCompany(Company company);
    }
}
