using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class User
    {
        public long UserId { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FullName { get; set; }

        public long? AddressId { get; set; }
        public Address? Address { get; set; }

        public long? CreditCardId { get; set; }
        public Address? CreditCard { get; set; }

    }
}
