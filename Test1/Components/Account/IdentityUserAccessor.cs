using Test1.Data;
using Microsoft.AspNetCore.Identity;

namespace Test1.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Test1User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Test1User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
