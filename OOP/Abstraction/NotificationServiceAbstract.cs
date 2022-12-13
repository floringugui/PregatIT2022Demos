using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    public abstract class NotificationServiceAbstract
    {
        public abstract void SendNotifications();

        public void PrepareNotification()
        {
            // do the preparing

            // calls the implementation of the abstract method (EmailNotificationServiceAbstract or SmsNotificationServiceAbstract)
            SendNotifications();
        }

        public virtual void AccomplishNotification()
        {
            // do the preparing

            // calls the implementation of the abstract method (EmailNotificationServiceAbstract or SmsNotificationServiceAbstract)
            SendNotifications();
        }
    }
}
