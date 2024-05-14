using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCCoreCustomerApplication
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Logic1Middleware
    {
        private readonly RequestDelegate _next;

        public Logic1Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("This is Logic1 \n");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Logic1MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogic1Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Logic1Middleware>();
        }
    }
}
