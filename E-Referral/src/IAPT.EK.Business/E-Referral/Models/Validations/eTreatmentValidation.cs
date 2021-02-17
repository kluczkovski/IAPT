using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eTreatmentValidation: AbstractValidator<eTreatment>
    {
        public eTreatmentValidation()
        {
            RuleFor(treat => treat.Service)
                    .NotNull().WithMessage("The field {PropertyName} must be informed.");

            RuleFor(treat => treat.TreatmentProvided)
                    .NotNull().WithMessage("The field {PropertyName} must be informed.");

        }
    }
}
