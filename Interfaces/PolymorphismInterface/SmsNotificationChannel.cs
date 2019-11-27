using System;

namespace PolymorphismInterface
{
    public class SmsNotificationChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
}