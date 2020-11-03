using System;
using FluentValidation;

namespace IAPT.EK.Business.Models.Validations
{
    public class eAgencyInformationValidation: AbstractValidator<eAgencyInformation>
    {
        public eAgencyInformationValidation()
        {
            // Agency
            RuleFor(ai => ai.Agency)
                    .NotEmpty().WithMessage("The field {PropertyName} must be informad on Agency Information.");

            // Conctact Person
            RuleFor(ai => ai.ContactPerson)
                   .NotNull().WithMessage("The field {PropertyName} must be informed on Agency Information.");

            RuleFor(ai => ai.AgencyHasClientConsent)
                    .NotNull().WithMessage("The field {PropertyName} must be informed on Agency Information.");
         }           
    }
}
