using System;
using FluentValidation;

namespace IAPT.EK.Business.Models.Validations
{
    public class CityValidation : AbstractValidator<City>
    {
        public CityValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(5, 50).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");
        }
    }
}
