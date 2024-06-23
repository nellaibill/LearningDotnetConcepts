using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
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
        private readonly MyMicroservice _microservice;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MyMicroservice microservice)
        {
            _logger = logger;
            _microservice = microservice;
        }

    
        [HttpGet(Name ="test")]
        public async Task<ActionResult<string>> GetDataFromMicroservice()
        {
            try
            {
                string data =  await _microservice.GetDataFromAnotherService();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
