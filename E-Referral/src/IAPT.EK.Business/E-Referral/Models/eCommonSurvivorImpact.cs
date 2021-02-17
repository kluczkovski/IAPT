using System;
using System.Collections.Generic;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eCommonSurvivorImpact: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public bool HasAnyIssuesWithDrugs { get; set; }

        public string HasAnyIssuesWithDrugsDetail { get; set; }

        public string HasOrHadEngagedAnyDrugTreatment { get; set; }

        public IEnumerable<eService> EServices { get; set; }

        public string CurrentTreatmentName { get; set; }

        public string CurrentTreatmentService { get; set; }

        public string CurrentTreatmentTel { get; set; }

        public string PrescribedAnyMedical { get; set; }

        public string PrescribedAnyMedicalDetails { get; set; }

        public bool ServedOrCurrentlyUnderInvestigation { get; set; }

        public IEnumerable<eOffence> EOffences { get; set; }

        public string ProbationServiceOrCRC { get; set; }

        public IEnumerable<eProbationService> EProbationServices { get; set; }

        public string FinalComments { get; set; }

        public eCommonSurvivorImpact()
        {
        }
    }
}
