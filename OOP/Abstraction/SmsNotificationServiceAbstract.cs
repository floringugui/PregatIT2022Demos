using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class SmsNotificationServiceAbstract : NotificationServiceAbstract
    {
        private string _phoneNumber;
        private string _messageBody;

        public SmsNotificationServiceAbstract(string phoneNumber, string messageBody)
            {
            _phoneNumber= phoneNumber;
            _messageBody= messageBody;
            }

        public override void SendNotifications()
        {
            // Send SMS notification service
        }

        public override void AccomplishNotification()
        {


            // Add custom Sms notification logic

            base.AccomplishNotification();
        }
    }
}
