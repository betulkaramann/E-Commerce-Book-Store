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
        public IActionResult Increment(int id)
        {
            Cart cart = _context.Carts.First((cart) => cart.Id == id);
            cart.Count += 1;
            _context.Carts.Update(cart);
            _context.SaveChanges();
            return RedirectToAction("CartContent");
        }
        public IActionResult Decrement(int id)
        {
            Cart cart = _context.Carts.First((cart) => cart.Id == id);
            cart.Count -= 1;
            _context.Carts.Update(cart);
            _context.SaveChanges();
            return RedirectToAction("CartContent");
        }

        public IActionResult Delete(int id)
        {
            Cart cart = _context.Carts.First((cart) => cart.Id == id);
            _context.Carts.Remove(cart);
            _context.SaveChanges();
            return RedirectToAction("CartContent");
        }
        public IActionResult Order()
        {

            var carts = _context.Carts.ToList();
            var order = new Order()
            {
                Address = new Address()
                {
                    City = "Hatay",
                    Description = "Döner",
                    District = "İskenderun",
                    DoorNumber = "07",
                    PostCode = 312200,
                    Street = "pirireis"
                },
                TotalPrice = 0
            };
            foreach (var cart in carts)
            {
                order.TotalPrice += 50 * cart.Count;
                cart.Order = order;
                cart.Visible = false;
                _context.Carts.Update(cart);
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("CartContent");

        }
    }
}
