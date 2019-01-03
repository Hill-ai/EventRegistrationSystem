﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EventRegistrationSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("FirstName", this.FirstName));
            userIdentity.AddClaim(new Claim("LastName", this.LastName));
            userIdentity.AddClaim(new Claim("HomeAddress", this.HomeAddress));
            return userIdentity;
        }
        //Added new change - FirstName attribute when someone Registers
        public string FirstName { get; internal set; }

        //Added new change - LastName attribute when someone Registers
        public string LastName { get; internal set; }

        //Added new change - HomeAddress attribute when someone Registers
        public string HomeAddress { get; internal set; }

        //Added new change - City attribute when someone Registers
        public string City { get; set; }

        //Added new change - StateZipCode attribute when someone Registers
        //public int? StateZipCode { get; set; }

        //Added new change - UserName attribute when someone Registers
        //public string UserName { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<EventRegistrationSystem.Models.Event> Events { get; set; }
    }
}