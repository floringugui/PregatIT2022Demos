using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class EmailNotificationServiceAbstract : NotificationServiceAbstract
    {
        private string _destinationEmailAddress;
        private string _subject;
        private string _body;
        private string _message;

        public EmailNotificationServiceAbstract(string destinationEmailAddress, string subject, string body, string message)
        {
            _destinationEmailAddress = destinationEmailAddress;
            _subject = subject;
            _body = body;
            _message = message;
        }


        public override void SendNotifications()
        {
            // trimite mail;
        }
    }
}
