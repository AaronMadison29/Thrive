using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThriveAPP
{

    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("halo@yahoo.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "halo@yahoo.com";
                user.Email = "halo@yahoo.com";

                IdentityResult result = userManager.CreateAsync(user, "Password!1").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Teacher").Wait();
                }

            }

            if (userManager.FindByNameAsync("halo2@yahoo.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "halo2@yahoo.com";
                user.Email = "halo2@yahoo.com";

                IdentityResult result = userManager.CreateAsync(user, "Password!1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Student").Wait();
                }
            }
        }
    }

}
