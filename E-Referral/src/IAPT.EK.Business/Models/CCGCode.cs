﻿using System;
namespace IAPT.EK.Business.Models
{
    public class CCGCode : Entity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string Hub { get; set; }

        public CCGCode()
        {
        }
    }
}
