using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities.Identity;

namespace Vezeta.Repository.Identity
{
    public class AppIdentityAppContext : IdentityDbContext<AppUser>
    {
        public AppIdentityAppContext(DbContextOptions<AppIdentityAppContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>()
            .Property(e => e.UserName);

            builder.Entity<AppUser>()
            .Property(e => e.UserName);
        }
    }
}
    