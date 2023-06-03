using Microsoft.AspNetCore.Mvc;

namespace TermProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginOut()
        {
            return View();
        }
    }
}
