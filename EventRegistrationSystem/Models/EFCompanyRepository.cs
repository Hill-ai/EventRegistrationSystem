using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using System.Data.Entity;

namespace EventRegistrationSystem.Models
{
    public interface IFactory<T>
    {
        T Create();
    }

    public class EFCompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();

        private IFactory<ApplicationDbContext> m_Factory;
        public EFCompanyRepository(IFactory<ApplicationDbContext> factory)
        {
            m_Factory = factory;
        }


        public IEnumerable<Company> Companies
        {

            get { return ctx.Companies; }
        }

        public void SaveCompany(Company company)
        {
            if (company.CompanyID == 0)
            {
                using (var context = m_Factory.Create())
                {
                    context.Companies.Add(company);
                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = m_Factory.Create())
                {
                    Company dbEntry = context.Companies.Find(company.CompanyID);
                    if (dbEntry != null)
                    {
                        dbEntry.Name = company.Name;
                        dbEntry.Address = company.Address;
                        dbEntry.PhoneNumber = company.PhoneNumber;
                        dbEntry.Email = company.Email;
                        dbEntry.PrimaryContactName = company.PrimaryContactName;
                        dbEntry.PrimaryContactPhoneNumber = company.PrimaryContactPhoneNumber;
                        dbEntry.PrimaryContactEmail = company.PrimaryContactEmail;
                        dbEntry.CompanyWebLink = company.CompanyWebLink;

                    }
                    context.SaveChanges();
                }
            }
        }


        public Company DeleteCompany(int companyID)
        {
            using (var context = m_Factory.Create())
            {
                Company dbEntry = context.Companies.Find(companyID);
                if (dbEntry != null)
                {
                    context.Companies.Remove(dbEntry);
                    context.SaveChanges();
                }
                return dbEntry;
            }
        }
    }
}

