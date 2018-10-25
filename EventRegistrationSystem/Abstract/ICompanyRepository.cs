using System.Collections.Generic;
using EventRegistrationSystem.Models; // I'm not using an Entity folder within a Domain Project to store the models



namespace EventRegistrationSystem.Abstract
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }
    }
}
