using EasyNetQ;
using EventListners.Messages;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventListners.Events
{
    public class PersonEvent : BackgroundService
    {
        private readonly IBus Bus;
        public PersonEvent(IBus bus)
        {
            Bus = bus;
        }
        protected override async  Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Bus.PubSub.Subscribe<Person>("Testing", Process);
        }

        private void Process(Person p)
        {
          var x = p;
        }
    }
}
