using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eService: Entity
    {
        public Guid ECommonSurvivorImpactId { get; set; }
        public eCommonSurvivorImpact ECommonSurvivorImpact { get; set; }

        public string Service { get; set; }

        public string TreatmentProvided { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public eService()
        {
        }
    }
}
