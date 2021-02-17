using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eRiskIndicator: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public string HasClientRisk { get; set; }

        public string Details { get; set; }

        public int SuicideRisk { get; set; }

        public int SelfHarmRisk { get; set; }

        public eRiskIndicator()
        {
        }
    }
}
