using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eTreatment : Entity
    {
        public Guid EClinicalReferralInfoID { get; set; }
        public eClinicalReferralInfo eClinicalReferralInfo { get; set; }

        public string Service  { get; set; }

        public string TreatmentProvided { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public eTreatment()
        {
        }
    }
}
