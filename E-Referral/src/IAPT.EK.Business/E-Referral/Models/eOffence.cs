using System;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models
{
    public class eOffence: Entity
    {
        public Guid ECommonSurvivorImpactId { get; set; }
        public eCommonSurvivorImpact ECommonSurvivorImpact { get; set; }

        public string Offence { get; set; }

        public string Conviction { get; set; }

        public string LengthOfSentence { get; set; }

        public string MonthYearSentence { get; set; }

        public eOffence()
        {
        }
    }
}
