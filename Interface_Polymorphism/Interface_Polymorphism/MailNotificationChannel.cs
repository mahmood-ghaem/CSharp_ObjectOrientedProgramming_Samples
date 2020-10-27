using System;

namespace Interface_Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending email from mail channel...");
        }
    }
}