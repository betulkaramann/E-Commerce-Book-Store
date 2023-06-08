using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class LoginModel
    {
        
        private string returnUrl;
        [Required(ErrorMessage ="Email is required!")]
        public string? LoginEmail { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string? LoginPassword { get; set; }

        //eğer giriş olursa ürün sayfasına yönlendirme
        public string ReturnUrl { 
            get
            {
                if (returnUrl == null)
                {
                    //anasayfa
                    return "/";
                }
                else
                {
                    return returnUrl;
                }
            } 
            set
            {
                returnUrl = value;
            } 
        }
    }
}
