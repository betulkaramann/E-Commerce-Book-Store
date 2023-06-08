using Microsoft.AspNetCore.Identity;
using TermProject.Models;

namespace TermProject.InfraStructure.Extention
{
    public static class ApplicationExtention
    {
        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder applicationBuilder) {

            AppDbContext context = applicationBuilder
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<AppDbContext>();

            const string adminUser = "cartcurt@gmail.com";
            const string adminPassword = "AdminAdminAdmin1.";

            //UserManager ve RoleManager burda
            UserManager<IdentityUser> userManager = applicationBuilder
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

       
            RoleManager<IdentityRole> roleManager = applicationBuilder
                .ApplicationServices
                .CreateAsyncScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user is null)
            {
                user = new IdentityUser()
                {
                    Email = "cartcurtybu@gmail.com",
                    PhoneNumber = "5061112233",
                    //UserName = adminUser,
                    NormalizedEmail = adminUser,
                };

                var result = await userManager.CreateAsync(user, adminPassword);

                if (!result.Succeeded)
                    throw new Exception("Admin user could not been created.");

                var roleResult = await userManager.AddToRolesAsync(user,
                    roleManager
                        .Roles
                        .Select(r => r.Name)
                        .ToList()
                );

                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with role defination for admin.");
            }
        }
    }
}
