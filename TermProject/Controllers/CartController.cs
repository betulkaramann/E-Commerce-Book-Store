using Microsoft.AspNetCore.Mvc;
using TermProject.Models;

namespace TermProject.Controllers
{
    public class CartController : Controller
    {
        private AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult CartContent()
        {
            var carts = _context.Carts.ToList();
            return View(carts);
        }
    }
}
