using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "The First Name Field is required"), MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "The Last Name Field is required"), MaxLength(100)]
        public string LastName { get; set; } = "";


        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = "";

        [Phone(ErrorMessage = "The format of the phone number should be valid"),MaxLength(20)]
        public string? PhoneNumber { get; set; } 

        [Required, MaxLength(200)]
        public string Address { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage ="The Confirm Password Field is required")]
        [Compare("Password",ErrorMessage = "Confirm Password and Password do not Match")]
        public string ConfirmPassword { get; set; } = "";
    
    }
}
