using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using System.Data.Entity;

namespace EventRegistrationSystem.Models
{
    public class EFCompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        
        public IEnumerable<Company> Companies
        {
            get { return context.Companies; }
        }
        public void SaveCompany(Company company)
        {
            if (company.CompanyID == 0)
            {
                context.Companies.Add(company);
            }
            else
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
            }
            context.SaveChanges();
        }

        public Company DeleteCompany(int companyID)
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

