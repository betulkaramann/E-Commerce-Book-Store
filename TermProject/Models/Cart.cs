using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int Count { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}