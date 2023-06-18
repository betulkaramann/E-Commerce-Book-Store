using Microsoft.AspNetCore.Identity;

namespace TermProject.Services
{
    public class AuthManager : IAuthServices
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AuthManager(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IEnumerable<IdentityRole> GetRoles => roleManager.Roles;
    }
}
