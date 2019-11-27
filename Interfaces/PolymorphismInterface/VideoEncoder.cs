using System.Collections.Generic;
using System.Net.Http;

namespace PolymorphismInterface
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
            //video encode işleri..

            foreach (var notificationChannel in _notificationChannels)
            {
                notificationChannel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}