using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MVCCoreCustomerApplication
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Logic3Middleware
    {
        private readonly RequestDelegate _next;

        public Logic3Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("This is Logic3 \n");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Logic3MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogic3Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Logic3Middleware>();
        }
    }
}
