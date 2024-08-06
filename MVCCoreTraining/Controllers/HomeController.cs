using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MVCCoreTraining.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreTraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger,IConfiguration config,DBLayer db,IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
            var conn = config["ConnectionStrings"];
            Console.WriteLine(conn);
        }

        public IActionResult Index()
        {
            string emplist;
             if (!_cache.TryGetValue("EmployeeList", out emplist)) 
                { 
                  _cache.Set("EmployeeList", "Hello", TimeSpan.FromMinutes(10));
                }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
