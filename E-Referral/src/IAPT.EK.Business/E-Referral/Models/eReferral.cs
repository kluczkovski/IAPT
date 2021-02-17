using System;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eReferral: Entity
    {
        public DateTime ReceivedDate { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public StatusEReferralEnum Status { get; set; }
       
        
        // *EF Relation 
        public eAgencyInformation eAgencyInformation { get; set; }
        public eContactDetail eContactDetail { get; set; }
        public eDiversity eDiversity { get; set; }
        public eArmedForce eArmedForce { get; set; }
        public eLongTermPhysicalHealth eLongTermPhysicalHealth { get; set; }
        public eRiskIndicator eRiskIndicator { get; set; }
        public eClinicalReferralInfo EClinicalReferralInfo { get; set; }
        public eIsvaReferralInfo eIsvaReferralInfo { get; set; }
        public eSexualOffence eSexualOffence { get; set; }
        public eCommonSurvivorImpact eCommonSurvivorImpact { get; set; }

        public eReferral()
        {
            this.ReceivedDate = DateTime.Now;
            this.Status = StatusEReferralEnum.Pending;
        }
    }
}
