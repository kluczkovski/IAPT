using System;
namespace IAPT.EK.API.DTO.EReferral
{
    public class eArmedForceDTO
    {
        public Guid? Id { get; set; }

        public bool memberOfArmedForce { get; set; }

        public string HasLinkedWithArmedForce { get; set; }

        public string Branch { get; set; }

        public string ServiceNumber { get; set; }

        public eArmedForceDTO()
        {
        }
    }
}
