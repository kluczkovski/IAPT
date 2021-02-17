using System;
using System.ComponentModel.DataAnnotations;

namespace IAPT.EK.API.DTO.EReferral
{
    public class eRiskIndicatorDTO
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "The field {0} must be informed on Diversity.")]
        public string HasClientRisk { get; set; }

        public string Details { get; set; }

        public int SuicideRisk { get; set; }

        public int SelfHarmRisk { get; set; }

        public eRiskIndicatorDTO()
        {
        }
    }
}
