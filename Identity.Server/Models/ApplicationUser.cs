using Microsoft.AspNetCore.Identity;

namespace Identity.Server.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public string PhoneNumber { get; set; }
    }
}
