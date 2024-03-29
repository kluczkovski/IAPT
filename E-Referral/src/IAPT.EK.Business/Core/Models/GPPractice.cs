﻿using System;
using System.Collections.Generic;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Models
{
    public class GPPractice : Entity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressLine4 { get; set; }

        public string AddressLine5 { get; set; }

        public string PostCode { get; set; }

        public Guid? CCGCodeId { get; set; }
        public CCGCode CCGCode { get; set; }


        // EF
        public IEnumerable<eContactDetail> eContactDetails { get; set; }

        public GPPractice()
        {
        }
    }
}
