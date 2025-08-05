using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class PasswordDto
    {

        [Required(ErrorMessage = "The Current Password Field is required"), MaxLength(100)]
        public string CurrentPassword { get; set; } = "";

        [Required(ErrorMessage = "The New Password Field is required"), MaxLength(100)]
        public string NewPassword { get; set; } = "";


        [Required(ErrorMessage = "The Confirm Password Field is required")]
        [Compare("NewPassword", ErrorMessage = "Confirm Password and Password do not Match")]
        public string ConfirmPassword { get; set; } = "";
    }
}
