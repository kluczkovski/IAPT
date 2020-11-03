using System;
using System.ComponentModel;

namespace IAPT.EK.Business.Models.Enums
{
    public enum SexualityEnum
    {
        Heterosexual = 0,

        [Description("Gay/Lesbian")]
        Gay_Lesbian = 1,

        [Description("Bi-Sexual")]
        Bi_Sexual = 2,

        Unknown = 3,

        [Description("Not Stated")]
        Not_Stated = 4
    }
}
