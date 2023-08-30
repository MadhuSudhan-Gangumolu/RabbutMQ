using EasyNetQ;
using EventListners.Messages;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace RabbutMQ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBus Bus;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBus bus)
        {
            _logger = logger;
            Bus = bus;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public void Get()
        {
            //var request = "{\"SAP-NAME\":\"Madhu\",\"SAP-LNAME\":\"Gangumolu\",\"SAP-GENDER\":\"Male\"}";

            //var res = System.Text.Json.JsonSerializer.Deserialize<Person>(request);

            //var messageBus = RabbitHutch.CreateBus("host=localhost");

            //messageBus.PubSub.Publish<Person>(res);
            var p = new Person { Name = "Madhu", GENDER = "Male" };
            Bus.PubSub.Publish(p);
        }
    }
}