using System;
using System.Collections.Generic;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Models
{
    public class EthnicCategory : Entity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public int Sequence { get; set; }

        //EF
        public IEnumerable<eDiversity> EDiversities { get; set; }

        public EthnicCategory()
        {
        }
    }
}
