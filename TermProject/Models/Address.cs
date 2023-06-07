using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public int PostCode { get; set; }

        public string Street { get; set; }
        public string DoorNumber { get; set; }
        public string Description { get; set; }
    }
}