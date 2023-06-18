using Microsoft.AspNetCore.Mvc;
using TermProject.Services;

namespace TermProject.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {

        private readonly IServicesManager servicesManager;

        public RoleController(IServicesManager servicesManager)
        {
            this.servicesManager = servicesManager;
        }


        public IActionResult Index()
        {
            return View(servicesManager.AuthServices.GetRoles);
        }
    }
}
