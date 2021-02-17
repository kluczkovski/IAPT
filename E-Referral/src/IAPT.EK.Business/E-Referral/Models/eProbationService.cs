using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eProbationService: Entity
    {
        public Guid ECommonSurvivorImpactId { get; set; }
        public eCommonSurvivorImpact ECommonSurvivorImpact { get; set; }

        public string Name { get; set; }

        public string Service { get; set; }

        public string Telephone { get; set; }

        public bool ConsentToContact { get; set; }

        public eProbationService()
        {
        }
    }
}
