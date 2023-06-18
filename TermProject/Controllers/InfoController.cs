using Microsoft.AspNetCore.Mvc;
using TermProject.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace TermProject.Controllers
{
    public class InfoController : Controller
    {
        private AppDbContext _context;

        public InfoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Info(int id)
        {
            Book book = _context.Books.First((book) => book.BookId == id);
            return View(book);
        }

        public IActionResult AddToCard(int? id)
        {
            Book book = _context.Books.First((book) => book.BookId == id);
            _context.Carts.Add(new Cart()
            {
                Book = book,
                Count = 1,
            });
            return RedirectToAction("CartContent", "Cart");
        }
    }
}

