using System.Collections.Generic;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Abstract
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }
    }
}
