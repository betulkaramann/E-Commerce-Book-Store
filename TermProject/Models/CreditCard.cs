using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        public float number { get; set; }

        public int cvv { get; set; }

        public DateTime date { get; set; }
    }
}