using LearningMVCCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace LearningMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MySettings _mySettings;

        public HomeController(ILogger<HomeController> logger, IOptions<MySettings> mySettings)
        {
            _logger = logger;
            _mySettings = mySettings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<string> GetContentResult()
        {
            return Content("<h1>Hello 123</h1> "+ _mySettings.Setting1+"", "text/html");
        }
        public IActionResult GetJsonData()
        {
            return Json(CreateContactModal());
        }
        public ActionResult PassModalToView()
        {
            return View("Privacy", CreateContactModal());

        }
        public  ActionResult RedirectToPrivacy()
        {
            TempData["Message"] = "I am coming from TempData";
           return  RedirectToAction("Privacy", CreateContactModal());
        }
        public IActionResult Privacy()
        {
            ViewBag.Message = "Hello I am from Action";
            ViewBag.Message = TempData["Message"];
            return View(CreateContactModal());
        }
        public ContactModal CreateContactModal()
        {
           return  new ContactModal { Name = "Saleem", Email = "saleem@gmail.com" };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class ContactModal
    {
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
