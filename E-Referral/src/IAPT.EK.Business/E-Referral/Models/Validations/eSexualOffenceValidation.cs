using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eSexualOffenceValidation: AbstractValidator<eSexualOffence>
    {
        public eSexualOffenceValidation()
        {
            RuleFor(so => so.BriefSummary)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

            RuleFor(so => so.WhenWasIt)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

            RuleFor(so => so.OffenceType)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

            RuleFor(so => so.AgeAtTimeOfOffence)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

            RuleFor(so => so.WhatWasGenderOfPerpetror)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

            RuleFor(so => so.WhatWasRelationshipToPerpetror)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Referral Information.");

        }
    }
}
