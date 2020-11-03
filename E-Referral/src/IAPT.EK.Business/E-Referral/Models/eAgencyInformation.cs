using System;
namespace IAPT.EK.Business.Models
{
    public class eAgencyInformation: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public string Agency { get; set; }

        public string ContactPerson { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool AgencyHasClientConsent { get; set; }


        public eAgencyInformation()
        {
        }
    }
}
