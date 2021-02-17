using System;
using FluentValidation;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eArmedForceValidation: AbstractValidator<eArmedForce>
    {
        public eArmedForceValidation()
        {
            // Check Armed Forced
            // - Member Of Armed Force
            RuleFor(af => af.MemberOfArmedForce)
                .NotNull().WithMessage("The field {PropertyName} must be informed on Armed Force Detail");

            // - Service Number
            RuleFor(af => af.HasLinkedWithArmedForce)
                .NotNull().When(x => x.MemberOfArmedForce).WithMessage("The field {PropertyName} must be informed on Armed Force Detail");

        }
    }
}
