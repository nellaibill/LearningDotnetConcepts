using Microsoft.AspNetCore.Mvc;
using LearningMVCCore.Models;
namespace LearningMVCCore.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
          ViewBag.Countries = UserModel.GetCountries();
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            ViewBag.Countries = UserModel.GetCountries();
            return View(model);
        }
    }
}
