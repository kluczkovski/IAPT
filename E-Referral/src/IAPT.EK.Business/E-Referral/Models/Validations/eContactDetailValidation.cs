using System;
using FluentValidation;
using IAPT.EK.Business.EReferral.Models;

namespace IAPT.EK.Business.Models.Validations
{
    public class eContactDetailValidation : AbstractValidator<eContactDetail>
    {
        public eContactDetailValidation()
        {
            // First Name
            RuleFor(cd => cd.FirstName)
                .NotEmpty().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");

            // Last Name
            RuleFor(cd => cd.LastName)
                .NotEmpty().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");

            // Birthday
            RuleFor(cd => cd.BirthDay)
                .NotNull().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");

            // Postcode
            RuleFor(cd => cd.PostCode)
                .NotNull().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");

            // Address 1
            RuleFor(cd => cd.Address1)
                .NotNull().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");

            // City or other city
            RuleFor(cd => cd.CityId)
                .NotEmpty().When(cd => cd.anotherCity is null).WithMessage("The field City or Another city must be informed");

            // Method of contact
            RuleFor(cd => cd.MethodsToContact)
                .NotEmpty().WithMessage("The field {PropertyName} must be informad on Conctact Detail.");
        }
    }
}
