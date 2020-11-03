using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class eAgencyInformationDTO
    {
        public Guid? Id { get; set; }

        public string Agency { get; set; }

        public string ContactPerson { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool? AgencyHasClientConsent { get; set; }

         public eAgencyInformationDTO()
        {
        }
    }
}
