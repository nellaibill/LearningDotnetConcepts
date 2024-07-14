using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
   // [ServiceFilter(typeof(CustomExceptionFilter))]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ResponseCache(Duration = 60)]
        public IActionResult Get()
        {
            _logger.LogInformation("Executing Get action");
            try
            {
                // Your logic here
                _logger.LogInformation("Successfully executed Get action");
                return Ok(new { Message = "Success" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while executing Get action");
                return StatusCode(500, "Internal server error");
            }
           // throw new NotImplementedException();
            //HttpContext.Session.SetString("SessionKeyName", "SessionKeyValue");
            //return Ok("This is a cached response.");
        }
    }


    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ValuesV2Controller : ControllerBase
    {
        [HttpGet]
        [ResponseCache(Duration = 60)]
        [HttpGet]
        public IActionResult Get()
        {
            var sessiondata = HttpContext.Session.GetString("SessionKeyName");
            return Ok(sessiondata);
        }
    }
}
