
using TermProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace TermProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        IEnumerable<Book> booksList;

        public ProductsController(AppDbContext db)
        {
            _db = db;
            booksList = _db.Books;
        }
        public IActionResult Index(long? id)
        {
            if (id != null)
            {
                Book book = _db.Books.First((e) => e.BookId == id);
                _db.Carts.Add(new Cart
                {
                    Book = book,
                    Count = 1,
                });
            }
            return View(booksList);
        }
    }
}