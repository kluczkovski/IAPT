using System;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.Business.Models
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

        public eReferral()
        {
            this.ReceivedDate = DateTime.Now;
            this.Status = StatusEReferralEnum.Pending;
        }
    }
}
