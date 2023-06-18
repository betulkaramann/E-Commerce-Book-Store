using Microsoft.AspNetCore.Mvc;

namespace TermProject.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
