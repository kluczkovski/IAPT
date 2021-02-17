using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eSexualOffence: Entity
    {
        public Guid eReferralId { get; set; }
        public eReferral EReferral { get; set; }

        public string BriefSummary { get; set; }

        public string WhenWasIt { get; set; }

        public string OffenceType { get; set; }

        public string AgeAtTimeOfOffence { get; set; }

        public string WhatWasGenderOfPerpetror { get; set; }

        public string WhatWasRelationshipToPerpetror { get; set; }

        public eSexualOffence()
        {
        }
    }
}
