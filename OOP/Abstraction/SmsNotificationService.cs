using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class SmsNotificationService : INotificationService
    {
        private string _phoneNumber;
        private string _messageBody;

        public SmsNotificationService(string phoneNumber, string messageBody)
        {
            _phoneNumber = phoneNumber;
            _messageBody = messageBody;
        }

        public void SendNotifications()
        {
            // Send SMS notification service
        }
    }
}
