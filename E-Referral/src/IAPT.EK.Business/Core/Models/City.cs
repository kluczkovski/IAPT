using System;
using System.Collections.Generic;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Models
{
    public class City : Entity
    {
        public string Name { get; set; }

        // EF
        public IEnumerable<eContactDetail> EContactDetails { get; set; }

        public City()
        {
        }
    }
}
