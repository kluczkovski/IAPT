using System;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.Business.Models
{
    public class eDiversity : Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public GenderEnum Gender { get; set; }

        public string IsgenderAssignedAtBirth { get; set; }

        public Guid EthnicCategoryId { get; set; }
        public EthnicCategory EthnicCategory { get; set; }

        public SexualityEnum Sexuality { get; set; }

        public Guid ReligionId { get; set; }
        public ReligiousGroup Religion { get; set; }

        public MaritalStatusEnum MaritalStatus { get; set; }

        public ParentalStatusEnum ParentalStatus { get; set; }

        public string PhysicalDisability { get; set; }

        public string PhysicalDisabilityState { get; set; }

        public string SpecificSupportNeeds { get; set; }

        public string SpecificSupportNeedState { get; set; }

        public eDiversity()
        {
        }
    }
}
