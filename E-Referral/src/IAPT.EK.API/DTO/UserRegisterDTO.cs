using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "The field {0} must be informed.")]
        [EmailAddress(ErrorMessage = "The field {0} shoud be valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        [StringLength(50, ErrorMessage = "The field {0} shoud be between {2} and {1} caracters.", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords are not equals.")]
        public string ConfirmPassword { get; set; }


        public UserRegisterDTO()
        {
        }
    }
}
