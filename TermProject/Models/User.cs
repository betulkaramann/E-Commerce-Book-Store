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

        public string Address { get; set; }
    }
}
