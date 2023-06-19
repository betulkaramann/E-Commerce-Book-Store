using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Cart> Carts { get; } = new List<Cart>();
    }
}