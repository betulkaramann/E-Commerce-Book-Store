using System.ComponentModel.DataAnnotations;

namespace TermProject.Entities
{
    //record keywordünü veri transfer nesneleri data transfer objects - DTOs gibi
    //basit veri taşıyıcılarını tanımlamak için kullanıldı
    public record RegisterDto
    {
        [Required(ErrorMessage = "Email is required")]
        public String? Email { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public String? Password { get; init; }

        [Required(ErrorMessage = "Name and Surname is required")]
        public String? FullName { get; init; }

        [Required(ErrorMessage = "Address is required")]
        public String? Address { get; init; }
    }
}
