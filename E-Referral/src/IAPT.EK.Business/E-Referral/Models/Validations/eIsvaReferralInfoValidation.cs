using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eIsvaReferralInfoValidation : AbstractValidator<eIsvaReferralInfo>
    {
        public eIsvaReferralInfoValidation()
        {
            RuleFor(isva => isva.IsvaReferralService)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

            RuleFor(isva => isva.CurrentlyReceivingSupport)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

            RuleFor(isva => isva.AttendSexualAssaultRefCenter)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

            RuleFor(isva => isva.PoliceInvolved)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

            RuleFor(isva => isva.CurrentOpenInvestigation)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

            RuleFor(isva => isva.VictimSupportBeenContact)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on ISVA Referral");

        }
    }
}
