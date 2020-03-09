using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class EthnicCategoryDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        [StringLength(50, ErrorMessage = "The field {0} shoud be between {2} and {1} caracters.", MinimumLength = 5)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        public int Sequence { get; set; }
       
    }
}
