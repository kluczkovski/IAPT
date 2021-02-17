using System;
using System.ComponentModel.DataAnnotations;
using IAPT.EK.API.DTO.EReferral;
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

        public eArmedForceDTO ArmedForceDetail { get; set; }

        public eLongTermPhysicalHealthDTO LongTermPhysicalHealth { get; set; }

        public eRiskIndicatorDTO RiskIndicator { get; set; }

        public eClinicalReferralInfoDTO ClinicalReferral { get; set; }

        public eIsvaReferralInfoDTO IsvaReferral { get; set; }

        public eSexualOffenceDTO ReferralInformation { get; set; }

        public eCommonSurvivorImpactDTO CommonSurvivorImpact { get; set; }

        public eReferralDTO()
        {
        }
    }
}
