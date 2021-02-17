using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eLongTermPhysicalHealthValidation: AbstractValidator<eLongTermPhysicalHealth>
    {
        public eLongTermPhysicalHealthValidation()
        {
            RuleFor(lt => lt.HasClientLTPH)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Long Term Physical Health Indicator.");

            RuleFor(lt => lt.Details)
                .NotNull().When(x => x.HasClientLTPH == "Yes")
                .WithMessage("The field {PropertyName} must be informed on Long Term Physical Health Indicator.");
        }
    }
}
