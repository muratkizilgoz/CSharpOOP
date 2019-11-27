using System;

namespace PolymorphismInterface
{
    public class MailNotificationChannel:INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Mail gönderildi");
        }
    }
}