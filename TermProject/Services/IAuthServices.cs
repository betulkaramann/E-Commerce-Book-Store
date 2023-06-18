using Microsoft.AspNetCore.Identity;

namespace TermProject.Services
{
    public interface IAuthServices
    {
        IEnumerable<IdentityRole> GetRoles { get; }
    }
}
