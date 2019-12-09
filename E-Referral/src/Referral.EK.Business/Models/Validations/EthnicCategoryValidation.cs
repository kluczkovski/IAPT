using System;
using FluentValidation;

namespace Referral.EK.Business.Models.Validations
{
    public class EthnicCategoryValidation : AbstractValidator<EthnicCategory>
    {
        public EthnicCategoryValidation()
        {
            RuleFor(e => e.Code)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed")
                .Length(2).WithMessage("The field {PropertyName} must have {MinLength} caracters.");

            RuleFor(e => e.Description)
                .NotEmpty().WithMessage("The field {PropertyName} must be informed.")
                .Length(5, 50).WithMessage("The field {PropertyName} shoud be between {MinLength} and {MaxLength} caracters.");

            RuleFor(e => e.Sequence)
                .NotNull().WithMessage("The field {PropertyName} must be informed.");
        }
    }
}
