using System;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eCommonSurvivorImpactDTO
    {
        public Guid Id { get; set; }
       
        public bool HasAnyIssuesWithDrugs { get; set; }

        public string HasAnyIssuesWithDrugsDetail { get; set; }

        public string HasOrHadEngagedAnyDrugTreatment { get; set; }

        public eServiceDTO[] ListOfTreatments { get; set; }

        public string CurrentTreatmentName { get; set; }

        public string CurrentTreatmentService { get; set; }

        public string CurrentTreatmentTel { get; set; }

        public string PrescribedAnyMedical { get; set; }

        public string PrescribedAnyMedicalDetails { get; set; }

        public bool ServedOrCurrentlyUnderInvestigation { get; set; }

        public eOffenceDTO[] ListOfOffences { get; set; }

        public string ProbationServiceOrCRC { get; set; }

        public eProbationServiceDTO[] ListOfProbations { get; set; }

        public string FinalComments { get; set; }

        public eCommonSurvivorImpactDTO()
        {
        }
    }
}
