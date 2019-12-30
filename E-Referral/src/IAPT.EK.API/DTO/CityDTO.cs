using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class CityDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        [StringLength(50, ErrorMessage = "The field {0} shoud be between {2} and {1} caracters.", MinimumLength = 5)]
        public string Name { get; set; }

   
        public CityDTO()
        {
        }
    }
}
