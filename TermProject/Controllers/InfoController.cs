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
            Console.WriteLine("id burdaaa : " + id.ToString());
            var books = _context.Books.ToList();
            return View(books);
        }
    }
}
