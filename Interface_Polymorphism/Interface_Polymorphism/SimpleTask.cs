using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    public class SimpleTask
    {
        //private readonly MailService _mailService;
        private readonly IList<INotificationChannel> _notificationChannels;
        public SimpleTask()
        {
            //_mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Task(Job job)
        {
            //Do some job here

            //Then send a mail
            //_mailService.Send(new Mail());
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}