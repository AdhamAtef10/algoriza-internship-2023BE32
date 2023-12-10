using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Vezeta.APIs.Extensions;
using Vezeta.APIs.Middlewares;
using Vezeta.Core.Entities;
using Vezeta.Core.Entities.Identity;
using Vezeta.Core.Repositories;
using Vezeta.Repository;
using Vezeta.Repository.Data;
using Vezeta.Repository.Identity;

namespace Vezeta.APIs
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            #region Configure Services
            builder.Services.AddControllers();

            builder.Services.AddSwaggerServices();
            builder.Services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddDbContext<AppIdentityAppContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection"));
            });
            builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

            builder.Services.AddIdentityServices(builder.Configuration);
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
            #endregion

            var app = builder.Build();

            using var scope = app.Services.CreateScope();  //"using" is insted of scope.Dispose()

            var services = scope.ServiceProvider;

            var loggerFactory=services.GetRequiredService<ILoggerFactory>();
            try
            {
                var appContext = services.GetRequiredService<ApplicationContext>(); // ASK CLR for creating Object From DbContext Explicity  
                await appContext.Database.MigrateAsync(); //update database
                var identityDbContext = services.GetRequiredService<AppIdentityAppContext>();
                await identityDbContext.Database.MigrateAsync();  // Apply Migration (Update Database).
                var AppUserManager = services.GetRequiredService<UserManager<AppUser>>();
                await AppIdentityAppContextSeed.SeedUsersAsync(AppUserManager);
            }
            catch(Exception ex)
            {
                var logger=loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "an error occured during apply the migration===>",ex.Message);
            }

            // Configure the HTTP request pipeline.
            #region Configure
            app.UseMiddleware<ExceptionMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwaggerMiddlewares();
            }
            app.UseStatusCodePagesWithReExecute("/errors/{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseAuthorization();
            app.MapControllers();

            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ar")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
            #endregion

            app.Run();
        }
    }
}

//Remove-Migration -context ApplicationContext
//Add-Migration -context ApplicationContext -o Data/Migrations
// Update-Database -context ApplicationContext
