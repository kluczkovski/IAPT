using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eRiskIndicatorValidation: AbstractValidator<eRiskIndicator>
    {
        public eRiskIndicatorValidation()
        {
            RuleFor(ri => ri.HasClientRisk)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Risk Indicator.");

            RuleFor(lt => lt.Details)
                .NotNull().When(x => x.HasClientRisk == "Yes")
                .WithMessage("The field {PropertyName} must be informed on Risk Indicator.");
        }
    }
}
