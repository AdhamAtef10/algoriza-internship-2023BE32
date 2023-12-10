using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Identity;

namespace Vezeta.Repository.Identity
{
    public static class AppIdentityAppContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> AppUserManager)
        {
            if (!AppUserManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Adham Atef",
                    Email = "adhamatef10@gmail.com",
                    UserName = "adhamatef",
                    PhoneNumber = "01286226375"
                };
                await AppUserManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
