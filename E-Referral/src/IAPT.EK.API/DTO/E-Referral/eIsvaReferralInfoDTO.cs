using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eIsvaReferralInfoDTO
    {
        public Guid? id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public bool IsvaReferralService { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public bool CurrentlyReceivingSupport { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public string AttendSexualAssaultRefCenter { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public bool PoliceInvolved { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public bool CurrentOpenInvestigation { get; set; }

        public string OfficerInChargeName { get; set; }

        public string OfficerInChargeService { get; set; }

        public string OfficerInChargeTel { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on ISVA Referral Info.")]
        public bool VictimSupportBeenContact { get; set; }

        public eIsvaReferralInfoDTO()
        {
        }
    }
}
