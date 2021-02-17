using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eLongTermPhysicalHealth: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public string HasClientLTPH { get; set; }

        public string Details { get; set; }

        public eLongTermPhysicalHealth()
        {
        }
    }
}
