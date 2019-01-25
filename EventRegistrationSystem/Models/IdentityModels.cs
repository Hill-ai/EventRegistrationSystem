using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EventRegistrationSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string FirstName { get; internal set; }
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string LastName { get; internal set; }
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string Address { get; internal set; }
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string City { get; internal set; }
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string Zip { get; internal set; }
        //Tuesday:1/8/19 Adding a new attribute to Asp.NetUsers Table
        public string State { get; internal set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
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

        public System.Data.Entity.DbSet<EventRegistrationSystem.Models.VolunteerEvent> VolunteerEvents { get; set; }

        public virtual System.Data.Entity.DbSet<EventRegistrationSystem.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<EventRegistrationSystem.Models.UsersVolunteerEvent> UsersVolunteerEvents { get; set; }
    }
}