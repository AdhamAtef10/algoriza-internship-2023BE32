using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Identity;

namespace Vezeta.Core.Services
{
    public interface ITokenService
    {
        Task<string> CreateTokenAsync(AppUser appUser, UserManager<AppUser> appUserManager);
    }
}
