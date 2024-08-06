using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
     [ServiceFilter(typeof(CustomExceptionFilter))]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
           
        private readonly IAntiforgery _antiforgery;

        public ValuesController(ILogger<ValuesController> logger, IAntiforgery antiforgery)
        {
            _logger = logger;
            _antiforgery = antiforgery;
        }

        [HttpGet("api/csrf-token")]
        public IActionResult GetCsrfToken()
        {
            var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
            return Ok(new { token = tokens.RequestToken });
        }
        [HttpGet]
        [ResponseCache(Duration = 600)]
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
            var sessionData = HttpContext.Session.GetString("SessionKeyName");

            if (string.IsNullOrEmpty(sessionData))
            {
                return NotFound("Session data not found");
            }

            return Ok(sessionData);

        }
    }
    

}
