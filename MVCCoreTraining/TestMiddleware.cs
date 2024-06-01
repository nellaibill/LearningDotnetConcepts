using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCCoreTraining
{
    public class TestMiddleware
    {
        private readonly RequestDelegate next;

        public TestMiddleware(RequestDelegate _next)
        {
            next = _next;
        }
        public Task Invoke(HttpContext context)
        {
            System.Console.WriteLine("Test Middleware Executed");
            return next(context);
        }
    }
}
