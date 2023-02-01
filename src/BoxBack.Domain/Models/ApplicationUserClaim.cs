using Microsoft.AspNetCore.Identity;

namespace BoxBack.Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
    }
}