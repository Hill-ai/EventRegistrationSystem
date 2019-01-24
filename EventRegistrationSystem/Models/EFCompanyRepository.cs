using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Models
{
    public class EFCompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IEnumerable<Company> Companies
        {
            get { return context.Companies; }
        }
        public void SaveCompany(Company Company)
        {
            if (Company.CompanyID == 0)
            {
                context.Companies.Add(Company);
            }
            else
            {
                Company dbEntry = context.Companies.Find(Company.CompanyID);
                if (dbEntry != null)
                {
                    dbEntry.Name = Company.Name;
                    dbEntry.Address = Company.Address;
                    dbEntry.PhoneNumber = Company.PhoneNumber;
                    dbEntry.Email = Company.Email;
                    dbEntry.PrimaryContactName = Company.PrimaryContactName;
                    dbEntry.PrimaryContactPhoneNumber = Company.PrimaryContactPhoneNumber;
                    dbEntry.PrimaryContactEmail = Company.PrimaryContactEmail;
                    dbEntry.CompanyWebLink = Company.CompanyWebLink;

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

