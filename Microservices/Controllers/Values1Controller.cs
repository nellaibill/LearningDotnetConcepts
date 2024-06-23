using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Values1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var sessiondata =  HttpContext.Session.GetString("SessionKeyName");
            return Ok(sessiondata);
        }
    }
}
