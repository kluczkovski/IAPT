using System;
namespace IAPT.EK.API.DTO.EReferral
{
    public class eTreatmentDTO
    {
        public Guid? ID { get; set; }

        public string Service { get; set; }

        public string TypeOfTreatment { get; set; }

        public string StartTreament { get; set; }

        public string EndTreament { get; set; }

        public eTreatmentDTO()
        {
        }
    }
}
