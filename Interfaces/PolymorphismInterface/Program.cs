using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open Close

            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
           
        }
    }
}
