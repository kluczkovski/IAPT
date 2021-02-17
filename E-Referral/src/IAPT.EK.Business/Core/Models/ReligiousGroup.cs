using System;
using System.Collections.Generic;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Models
{
    public class ReligiousGroup : Entity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        //EF
        public IEnumerable<eDiversity> EDiversities { get; set; }

        public ReligiousGroup()
        {
        }
    }
}
