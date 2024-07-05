using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ServiceFilter(typeof(CustomExceptionFilter))]

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public string Get() { return "users"; }
    }

    [ApiController]
    [Route("[controller]")]
    [CustomActionFilter("From Controller")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            throw new Exception("Test exception");
            /*
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();*/
        }
    }
}