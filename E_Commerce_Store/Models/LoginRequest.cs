using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Store.Models
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }    
    }
}
