using EventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.DataAccess
{
    public class CompaniesDbContext : ApplicationDbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}