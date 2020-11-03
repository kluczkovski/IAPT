using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class eDiversityDTO
    {
        public eDiversityDTO()
        {
        }

        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string IsgenderAssignedAtBirth { get; set; }

        public Guid EthnicCategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string Sexuality { get; set; }

        public Guid ReligionId { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string ParentalStatus { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string PhysicalDisability { get; set; }

        public string PhysicalDisabilityState { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string SpecificSupportNeeds { get; set; }

        public string SpecificSupportNeedState { get; set; }
    }
}
