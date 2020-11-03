using FluentValidation;

namespace IAPT.EK.Business.Models.Validations
{
    public class CCGCodeValidation : AbstractValidator<CCGCode>
    {
        public CCGCodeValidation()
        {
            RuleFor(c => c.Code)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(3, 5).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(3, 50).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");

        }
    }
}
