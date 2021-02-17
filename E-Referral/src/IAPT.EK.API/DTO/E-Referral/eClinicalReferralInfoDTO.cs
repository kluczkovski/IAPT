using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eClinicalReferralInfoDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Clinical Referral Info.")]
        public bool ClinicalSupportService { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Clinical Referral Info.")]
        public bool AccessedSMBefore { get; set; }

        public string SMBeforeWhen { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Clinical Referral Info.")]
        public bool HasMentalHealthDiag { get; set; }

        public string StatedMentalHealth { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Clinical Referral Info.")]
        public bool AccessedCurrentlyOtherService { get; set; }

        public eTreatmentDTO[] ListOfServices { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Clinical Referral Info.")]
        public bool AccessingService { get; set; }

        public string AccessingServiceWorkName { get; set; }

        public string AccessingServiceWorkService { get; set; }

        public string AccessingServiceWorkTel { get; set; }

        public eClinicalReferralInfoDTO()
        {
        }
    }
}
