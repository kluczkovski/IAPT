using System;
using FluentValidation;
using IAPT.EK.Business.Models.Enums;

namespace IAPT.EK.Business.Models.Validations
{
    public class eReferralValidation: AbstractValidator<eReferral>
    {
        public eReferralValidation()
        {
            // Date witch the referral was received.
            RuleFor(e => e.ReceivedDate)
                    .NotNull().WithMessage("The field {PropertyName} must be informad.");

            // Type of Referral  (self/prof)
            RuleFor(e => e.Type)
                   .NotNull().WithMessage("The field {PropertyName} must be informed on Referral");

            // Check the enum
            RuleFor(e => e.Status).IsInEnum();
          
        }
    }
}
