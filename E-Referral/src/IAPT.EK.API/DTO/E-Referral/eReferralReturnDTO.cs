using System;
using System.ComponentModel.DataAnnotations;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.API.DTO
{
    public class eReferralReturnDTO
    {
        public Guid? Id { get; set; }

        public DateTime ReceivedDate { get; set; }

        public string Type { get; set; }

        public string Status { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string GPPracticeName{ get; set; }

        public string CCGCommissioner { get; set; }

        public eReferralReturnDTO()
        {
        }
    }
}
