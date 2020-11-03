using System;
using System.ComponentModel.DataAnnotations;
using IAPT.EK.Business.Models;

namespace IAPT.EK.API.DTO
{
    public class GPPracticeDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        [StringLength(6, ErrorMessage = "The field must have {1} caracters.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        [StringLength(50, ErrorMessage = "The field {0} shoud be between {2} and {1} caracters.", MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        public string PostCode { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressLine4 { get; set; }

        public string AddressLine5 { get; set; }

        public CCGCodeDTO CCGCode {get; set;}

        public GPPracticeDTO()
        {
        }
    }
}
