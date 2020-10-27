using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleTask = new SimpleTask();
            simpleTask.RegisterNotificationChannel(new MailNotificationChannel());
            simpleTask.RegisterNotificationChannel(new SmsNotificationChannel());
            simpleTask.Task(new Job());
            Console.ReadLine();
        }
    }
}
