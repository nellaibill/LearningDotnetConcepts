using Microsoft.AspNetCore.Mvc;

namespace MVCCoreTraining.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string customerName)
        {
            return Content(customerName);
        }

    }
}
