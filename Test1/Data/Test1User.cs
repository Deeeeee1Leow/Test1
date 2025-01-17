using Microsoft.AspNetCore.Identity;

namespace Test1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Test1User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
