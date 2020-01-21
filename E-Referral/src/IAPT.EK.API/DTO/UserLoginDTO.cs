using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "The field {0} must be informed.")]
        [EmailAddress(ErrorMessage = "The field {0} shoud be valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        public string Password { get; set; }


        public LoginUserDTO()
        {
        }
    }
}
