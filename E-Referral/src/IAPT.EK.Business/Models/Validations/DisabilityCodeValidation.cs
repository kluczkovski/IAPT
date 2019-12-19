using System;
using FluentValidation;

namespace IAPT.EK.Business.Models.Validations
{
    public class ReligiousGroupValidation : AbstractValidator<ReligiousGroup>
    {
        public ReligiousGroupValidation()
        {
            RuleFor(rg => rg.Code)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed");

            RuleFor(rg => rg.Description)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(5, 50).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");
        }
    }
}
