using System;
namespace IAPT.EK.API.DTO.EReferral
{
    public class eProbationServiceDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Service { get; set; }

        public string Telephone { get; set; }

        public bool ConsentToContact { get; set; }

        public eProbationServiceDTO()
        {
        }
    }
}
