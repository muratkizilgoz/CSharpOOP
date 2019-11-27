using System;

namespace PolymorphismInterface
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Mail Gönderildi");
        }
    }
}