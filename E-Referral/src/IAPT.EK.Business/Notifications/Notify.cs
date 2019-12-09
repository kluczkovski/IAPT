using System.Linq;
using System.Collections.Generic;
using IAPT.EK.Business.Interfaces;


namespace IAPT.EK.Business.Notifications
{
    public class Notify : INotify
    {
        private List<Notification> _notifications;

        public Notify()
        {
            _notifications = new List<Notification>();
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public List<Notification> ListOfNotifications()
        {
            return _notifications;
        }

        public bool IsThereNotification()
        {
            return _notifications.Any();
        }
    }
}
