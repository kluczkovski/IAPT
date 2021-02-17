using System;
using IAPT.EK.Business.Core.Models.Enums;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eArmedForce: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral EReferral { get; set; }

        public bool MemberOfArmedForce { get; set; }

        public string HasLinkedWithArmedForce { get; set; }

        public BranchEnum Branch { get; set; }

        public string ServiceNumber { get; set; }

        public eArmedForce()
        {
        }
    }
}
