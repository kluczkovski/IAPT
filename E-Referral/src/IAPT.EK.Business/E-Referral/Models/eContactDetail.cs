using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eContactDetail: Entity
    {
        public Guid EReferralId { get; set; }
        public eReferral eReferral { get; set; }

        public string NHSNumber { get; set; }

        public Guid? GpPracticeId { get; set; }
        public GPPractice GpPractice { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string PostCode { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public Guid? CityId { get; set; }
        public City City { get; set; }
        public string anotherCity { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string MethodsToContact { get; set; }


        public eContactDetail()
        {
        }
    }
}
