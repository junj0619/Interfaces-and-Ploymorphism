using System.Collections;
using System.Collections.Generic;
using Microsoft.Build.Tasks;

namespace Interfaces_and_Ploymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            //....

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotification(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}