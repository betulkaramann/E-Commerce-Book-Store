using Microsoft.AspNetCore.Mvc;

namespace TermProject.Controllers
{
    public class CartController : Controller
    {
        public IActionResult CartContent()
        {
            return View();
        }
    }
}
