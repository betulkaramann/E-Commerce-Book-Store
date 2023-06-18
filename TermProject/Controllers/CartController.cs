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
            Console.WriteLine(carts.ElementAt(0).Book);
            return View(carts);
        }
        public IActionResult Increment(int id)
        {
            Console.WriteLine("Azıcık sevseydin be");
            return RedirectToAction("CartContent");
        }
        public IActionResult Decrement(int id)
        {
            return RedirectToAction("CartContent");
        }
    }
}
