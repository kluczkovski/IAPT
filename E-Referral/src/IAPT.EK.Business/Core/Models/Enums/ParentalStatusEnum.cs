using System;
using System.ComponentModel;

namespace IAPT.EK.Business.Models.Enums
{
    public enum ParentalStatusEnum
    {
        [Description("Not a Parent")]
        NotAParent = 0,

        [Description("Yes, not live with")]
        Yes_NotLiveWith = 1,

        [Description("Yes, some live with")]
        Yes_SomeLiveWith = 2,

        [Description("Yes, all live with")]
        Yes_AllLiveWith = 3,

    }
}
