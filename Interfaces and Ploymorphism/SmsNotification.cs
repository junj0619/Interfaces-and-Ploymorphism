using System;

namespace Interfaces_and_Ploymorphism
{
    public class SmsNotificationChannel :INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Sms Notification.");
        }
    }
}