using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eClinicalReferralInfoValidation : AbstractValidator<eClinicalReferralInfo>
    {
        public eClinicalReferralInfoValidation()
        {
            RuleFor(cli => cli.ClinicalSupportService)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Clinical Referral");

            RuleFor(cli => cli.AccessedSMBefore)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Clinical Referral");

            RuleFor(cli => cli.HasMentalHealthDiag)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Clinical Referral");

            RuleFor(cli => cli.AccessedCurrentlyOtherService)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Clinical Referral");

            RuleFor(cli => cli.AccessingService)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Clinical Referral");

        }
    }
}
