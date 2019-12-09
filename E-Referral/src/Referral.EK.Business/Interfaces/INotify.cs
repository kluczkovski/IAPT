using System;
using System.Collections.Generic;
using Referral.EK.Business.Notifications;

namespace Referral.EK.Business.Interfaces
{
    public interface INotify
    {
        bool IsThereNotification();

        void Handle(Notification notification);

        List<Notification> ListOfNotifications();
    }
}
