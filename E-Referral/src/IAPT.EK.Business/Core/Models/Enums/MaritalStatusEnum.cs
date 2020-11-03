using System;
using System.ComponentModel;

namespace IAPT.EK.Business.Models.Enums
{
    public enum MaritalStatusEnum
    {
        Single = 10,

        Married = 20,

        [Description("Co Habiting")]
        Co_Habiting = 30,

        Widowed = 40,

        Divorced = 50,

        Declined = 60,

        Seperated = 70,

        [Description("Not Stated")]
        Not_Stated = 80,

        Partner = 90,

        Engaged = 100
    }
}
