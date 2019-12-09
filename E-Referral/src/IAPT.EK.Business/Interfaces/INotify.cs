using System;
using System.Collections.Generic;
using IAPT.EK.Business.Notifications;

namespace IAPT.EK.Business.Interfaces
{
    public interface INotify
    {
        bool IsThereNotification();

        void Handle(Notification notification);

        List<Notification> ListOfNotifications();
    }
}
