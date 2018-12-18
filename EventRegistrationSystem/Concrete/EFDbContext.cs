using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventRegistrationSystem.Models;
using System.Data.Entity;



namespace EventRegistrationSystem.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

    }
    
 }
 