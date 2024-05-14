using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCCoreCustomerApplication
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Logic2Middleware
    {
        private readonly RequestDelegate _next;

        public Logic2Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("This is Logic2 \n");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Logic2MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogic2Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Logic2Middleware>();
        }
    }
}
