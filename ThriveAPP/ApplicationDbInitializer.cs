using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using ThriveAPP.Models;

namespace ThriveAPP
{

    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager, ISchoolServices schoolService)
        {
            if (userManager.FindByNameAsync("skingsworth0@ucoz.ru").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "skingsworth0@ucoz.ru";
                user.Email = "skingsworth0@ucoz.ru";

                IdentityResult result = userManager.CreateAsync(user, "Password!1").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Teacher").Wait();
                }

                Teacher teacher = new Teacher
                {
                    Name = "Stace Kingsworth",
                    Email = "skingsworth0@ucoz.ru",
                    PhoneNumber = "578-682-6062",
                    Subject = "Math",
                    UserId = user.Id
                };

                schoolService.AddTeacherAsync(teacher).Wait();
            }

            if (userManager.FindByNameAsync("mradbond1@salon.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "mradbond1@salon.com";
                user.Email = "mradbond1@salon.com";

                IdentityResult result = userManager.CreateAsync(user, "Password!1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Teacher").Wait();
                }

                Teacher teacher = new Teacher
                {
                    Name = "Mahmoud Radbond",
                    Email = "mradbond1@salon.com",
                    PhoneNumber = "642-277-6160",
                    Subject = "Math",
                    UserId = user.Id
                };

                schoolService.AddTeacherAsync(teacher).Wait();
            }
        }
    }

}
