using Microsoft.AspNetCore.Mvc;

namespace LearningMVCCore.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return Content("<h1>hello</h1>", "text/html");
            // return View();
        }
        [Route("{id:int}")]
        public IActionResult GetDetailsById(int id )
        {
            return Content("<h1>hello " + id + "</h1>", "text/html");
            // return View();
        }

    }
}
