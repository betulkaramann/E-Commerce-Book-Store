using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;
using TermProject.Services;

namespace TermProject.InfraStructure.Extention
{
    public static class ServicesExtention
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
        {
            option.UseSqlServer(configuration.GetConnectionString("SqlCon"));
            option.EnableSensitiveDataLogging(true);
        }
    );
        }
    }
}
