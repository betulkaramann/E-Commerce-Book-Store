using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class User
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FullName { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public int CreditCardId { get; set; }
        public Address CreditCard { get; set; }

    }
}
