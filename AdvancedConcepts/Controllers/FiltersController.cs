using AdvancedConcepts.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedConcepts.Controllers
{
    [ServiceFilter(typeof(CustomExceptionFilter))]
    [Route("[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        [HttpGet("TestActionFilter")]
        [CustomActionFilter("From Controller")]
        public ActionResult<List<string>> GetListOfStrings()
        {
            List<string> strings = new List<string>
            {
                "string1",
                "string2",
                "string3"
            };

            return strings;
        }

        [HttpGet("ThrowException")]
        public ActionResult ThrowException()
        {
            throw new Exception("An exception occurred.");
        }
    }
}
