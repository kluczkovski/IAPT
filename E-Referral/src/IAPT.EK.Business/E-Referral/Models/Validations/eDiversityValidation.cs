using System;
using FluentValidation;
using IAPT.EK.Business.Models;

namespace IAPT.EK.Business.EReferral.Models.Validations
{
    public class eDiversityValidation: AbstractValidator<eDiversity>
    {
        public eDiversityValidation()
        {
            // Gender witch the referral was received.
            RuleFor(e => e.Gender).IsInEnum().WithMessage("The field {PropertyName} must be a valid value.");

            // Is this Gender you were assigned at birth?
            RuleFor(e => e.IsgenderAssignedAtBirth).NotNull().WithMessage("The field {PropertyName} must be informed.");

            // Ethinic
            RuleFor(e => e.EthnicCategoryId).NotNull().WithMessage("The field {PropertyName} must be informed.");

            // Sexuality
            RuleFor(e => e.Sexuality).IsInEnum().WithMessage("The field {PropertyName} must be a valid value.");

            // Religion
            RuleFor(e => e.ReligionId).NotNull().WithMessage("The field {PropertyName} must be informed.");

            // MaritalStatus
            RuleFor(e => e.MaritalStatus).IsInEnum().WithMessage("The field {PropertyName} must be informed.");

            // ParentalStatus
            RuleFor(e => e.ParentalStatus).IsInEnum().WithMessage("The field {PropertyName} must be informed.");

            // PhysicalDisability
            RuleFor(e => e.PhysicalDisability).NotNull().WithMessage("The field {PropertyName} must be informed.");

            // PhysicalDisabilityState
            RuleFor(e => e.PhysicalDisabilityState).NotNull().When(x => x.PhysicalDisability != "").WithMessage("The field {PropertyName} must be informed.");

            // SpecificSupportNeeds
            RuleFor(e => e.SpecificSupportNeeds).NotNull().WithMessage("The field {PropertyName} must be informed.");

            // PhysicalDisabilityState
            RuleFor(e => e.SpecificSupportNeedState).NotNull().When(x => x.SpecificSupportNeeds != "").WithMessage("The field {PropertyName} must be informed.");


        }
    }
}
