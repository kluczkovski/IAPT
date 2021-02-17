using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eLongTermPhysicalHealthDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string HasClientLTPH { get; set; }

        public string Details { get; set; }

        public eLongTermPhysicalHealthDTO()
        {
        }
    }
}
