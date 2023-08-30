using EasyNetQ;
using Listner;

var bus = RabbitHutch.CreateBus("host=localhost");

bus.PubSub.Subscribe()
Console.ReadKey();
static void Process(Person msg)
{
    Console.WriteLine("Processing Order: {0} -- Model: {1} -- Color: {2}",
        msg.Name,
        msg.LastName,
        msg.GENDER);
}

