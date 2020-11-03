using System;
using System.ComponentModel.DataAnnotations;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.API.DTO
{
    public class eReferralDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed.")]
        public string Type { get; set; }

        public string Source { get; set; }

        public eAgencyInformationDTO? AgencyInformation { get; set; }

        public eContactDetailDTO ContactDetail { get; set; }

        public eDiversityDTO DiversityDetail { get; set; }

        public eReferralDTO()
        {
        }
    }
}
