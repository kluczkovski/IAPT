using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Referral.EK.Business.Interfaces;
using Referral.EK.Business.Notifications;

namespace Referral.EK.API.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotify _notify;

        public MainController(INotify notify)
        {
            _notify = notify;
        }


        //Work with erros from ModelState
        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotifyErrorModelState(modelState);
            return CustomResponse();
        }


        protected ActionResult CustomResponse(Object result = null)
        {
            if (OperationValid())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    erros = _notify.ListOfNotifications().Select(m => m.Message)
                }); 
            }
        }


        protected bool OperationValid()
        {
            return !_notify.IsThereNotification();
        }


        protected void NotifyErrorModelState(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in erros)
            {
                var errorMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                NotifyError(errorMsg);
            }
        }


        protected void NotifyError(string errorMsg)
        {
            _notify.Handle(new Notification(errorMsg));
        }
    }
}
