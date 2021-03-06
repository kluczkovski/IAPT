﻿using FluentValidation;
using FluentValidation.Results;
using IAPT.EK.Business.Interfaces;
using IAPT.EK.Business.Models;
using IAPT.EK.Business.Notifications;

namespace IAPT.EK.Business.Services
{
    public abstract class BaseServices
    {
        private readonly INotify _notify;

        public BaseServices(INotify notify)
        {
            _notify = notify;
        }

        protected void NotificationService(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                NotificationService(error.ErrorMessage);
            }
        }

        protected void NotificationService(string message)
        {
            _notify.Handle(new Notification(message));
        }

        // TV = Entity Validation, ex.: VendorValidation
        // TE = Genericy Entity , ex.: Vendor
        protected bool RunValidation<TV, TE>(TV validation, TE entity) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entity);
            if (!validator.IsValid)
            {
                NotificationService(validator);
                return false;
            }
            return true;
        }

    }
}