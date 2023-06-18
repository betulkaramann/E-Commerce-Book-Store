using Microsoft.AspNetCore.Mvc;
using TermProject.Models;

namespace TermProject.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowProducts()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
    }
}
