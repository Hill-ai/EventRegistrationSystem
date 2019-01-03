using System.Security.Claims;
using System.Security.Principal;

namespace EventRegistrationSystem.Models.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserFirstName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FirstName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserLastName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LastName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserHomeAddress(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("HomeAddress");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}