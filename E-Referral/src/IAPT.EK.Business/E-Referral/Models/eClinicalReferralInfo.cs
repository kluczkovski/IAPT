using System;
using System.Collections.Generic;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eClinicalReferralInfo: Entity
    {
        public Guid eReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public bool ClinicalSupportService { get; set; }

        public bool AccessedSMBefore { get; set; }

        public string SMBeforeWhen { get; set; }

        public bool HasMentalHealthDiag { get; set; }

        public string StatedMentalHealth { get; set; }

        public bool AccessedCurrentlyOtherService { get; set; }

        public IEnumerable<eTreatment> OtherServices { get; set; }

        public bool AccessingService { get; set; }

        public string AccessingServiceWorkName { get; set; }

        public string AccessingServiceWorkService { get; set; }

        public string AccessingServiceWorkTel { get; set; }

        public eClinicalReferralInfo()
        {
        }
    }
}
