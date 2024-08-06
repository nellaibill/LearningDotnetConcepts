using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedConcepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        [HttpGet("genCounters")]
        public IActionResult GetGenCounters()
        {
            GC.Collect();
            int gen0Count = GC.CollectionCount(0);
            int gen1Count = GC.CollectionCount(1);
            int gen2Count = GC.CollectionCount(2);
            return Ok(new
            {
                Gen0Count = gen0Count,
                Gen1Count = gen1Count,
                Gen2Count = gen2Count
            });
        }

        [HttpGet("hugeLoop")]
        public IActionResult RunHugeLoop()
        {
            for (double i = 0; i <= 10000; i++)
            {
                Customer cust = new Customer();
                cust.Name = DateTime.Now.ToString();
            }
            return Ok();
        }
    }
    class Customer : IDisposable
    {
        public string Name { get; set; }

        ~Customer()
        {
            Dispose();
        }

        private void CleanUpUnusedMemory()
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            CleanUpUnusedMemory();
        }
    }
}
