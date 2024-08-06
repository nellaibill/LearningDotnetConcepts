using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedConcepts.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MultiThreadingController : ControllerBase
    {

        private string commonVariable = string.Empty;
        private readonly object commonLock = new object();

        [HttpGet("method1")]
        public IActionResult Method1()
        {

            Thread t1 = new Thread(() => CaptureLog("Method1"));
            t1.Start();

            return Ok();
        }

        [HttpGet("method2")]
        public IActionResult Method2()
        {
            Thread t2 = new Thread(() => CaptureLog("Method2"));
            t2.Start();

            return Ok();
        }
        [HttpGet("method3")]
        public IActionResult Method3()
        {
            throw new Exception("Test exception");
        }
                 

        private void CaptureLog(string actionName)
        {
            lock (commonLock)
            {
                commonVariable = actionName + " triggered";
                Thread.Sleep(3000);
                FileInfo log = new FileInfo("D:\\log.txt");
                using (StreamWriter sw = log.AppendText())
                {
                    sw.WriteLine(commonVariable);
                }
            }
        }
    }
}
