using EventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.DataAccess
{
    public class CompanyDbContext : ApplicationDbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}