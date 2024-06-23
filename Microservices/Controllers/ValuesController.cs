using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [ResponseCache(Duration = 60)]
        public IActionResult Get()
        {
            HttpContext.Session.SetString("SessionKeyName", "SessionKeyValue");
            return Ok("This is a cached response.");
        }
    }
}
