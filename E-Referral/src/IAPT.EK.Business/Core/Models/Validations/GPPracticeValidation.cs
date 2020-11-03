using FluentValidation;

namespace IAPT.EK.Business.Models.Validations
{
    public class GPPracticeValidation : AbstractValidator<GPPractice>
    {
        public GPPracticeValidation()
        {
            RuleFor(c => c.Code)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(6).WithMessage("The field {PropertyName} must have {Lenght} caracters.");

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(3, 50).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");

            RuleFor(c => c.PostCode)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed");
        }
    }
}
