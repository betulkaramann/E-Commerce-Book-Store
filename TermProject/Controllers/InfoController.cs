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
            Console.WriteLine("HLLLEOdx");
            Book book = _context.Books.First((book) => book.BookId == id);
            return View(book);
        }

        public IActionResult AddToCard(int? id)
        {
            Console.WriteLine("HLLLEO");
            Book book = _context.Books.First((book) => book.BookId == id);
            Console.WriteLine("HLLLEO");
            var card = new Cart()
            {
                Book = book,
                Count = 1,
            };
            _context.Carts.Add(card);
            _context.SaveChanges();
            return RedirectToAction("CartContent", "Cart");
        }
    }
}

