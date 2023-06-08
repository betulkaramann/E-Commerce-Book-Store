using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TermProject.Models;

namespace TermProject.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Login([FromForm] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.LoginEmail);

                //kulllanıcının tanınım login olması
                if(user != null)
                {
                    //oturumu burda açalım giriş yapan varsa çıkışını SignOutAsync ile sağlayalım
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,loginModel.LoginPassword,false,false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/");
                    }
                }
                ModelState.AddModelError("Error","Invalid email or password");
            }

            return View();
        }


        public async Task<IActionResult> Logout([FromQuery(Name = "ReturnUrl")] string ReturnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(ReturnUrl);
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
