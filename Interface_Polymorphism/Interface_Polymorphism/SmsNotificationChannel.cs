using System;

namespace Interface_Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending sms from sms channel...");
        }
    }
}