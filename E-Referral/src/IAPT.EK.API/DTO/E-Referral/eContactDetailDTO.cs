using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO
{
    public class eContactDetailDTO
    {
        public Guid? Id { get; set; }

        public string NHSNumber { get; set; }

        public Guid GpPracticeId { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Contact Detail.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Contact Detail.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Contact Detail.")]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Contact Detail.")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public Guid CityId { get; set; }
        public string anotherCity { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Contact Detail.")]
        public string PostCode { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string[] MethodsToContact { get; set; }

        public eContactDetailDTO()
        {
        }
    }
}
