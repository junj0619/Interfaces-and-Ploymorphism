using System;

namespace Interfaces_and_Ploymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail Notification.");
        }
    }
}