using System.ComponentModel.DataAnnotations;

namespace ExoAPI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Requirido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Requirida")]
        public string Senha { get; set; }
    }
}