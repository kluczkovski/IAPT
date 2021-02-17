using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eIsvaReferralInfo: Entity
    {
        public Guid eReferralId { get; set; }
        public eReferral EReferral { get; set; }

        public bool IsvaReferralService { get; set; }

        public bool CurrentlyReceivingSupport { get; set; }

        public string AttendSexualAssaultRefCenter { get; set; }

        public bool PoliceInvolved { get; set; }

        public bool CurrentOpenInvestigation { get; set; }

        public string OfficerInChargeName { get; set; }

        public string OfficerInChargeService { get; set; }

        public string OfficerInChargeTel { get; set; }

        public bool VictimSupportBeenContact { get; set; }

        public eIsvaReferralInfo()
        {
            
        }
    }
}
