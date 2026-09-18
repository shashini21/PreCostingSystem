using System.ComponentModel.DataAnnotations;

namespace PRC_PreCosting_MVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your login name.")]
        [Display(Name = "Login Name")]
        public string LogName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;
    }
}