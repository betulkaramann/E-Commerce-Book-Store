using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using TermProject.Models;

namespace TermProject.Services
{
    public static class ServicesExtention
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>( option =>
    {
        option.UseSqlServer(configuration.GetConnectionString("SqlCon"));
        option.EnableSensitiveDataLogging(true);
    }
    );
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(option =>
            {
                option.SignIn.RequireConfirmedEmail = false; //mail onayı
                //burdan email ve şifrelerin içeriği hakkında ayarlama yapacağız.
            }).AddEntityFrameworkStores<AppDbContext>();
        }
    }
}
