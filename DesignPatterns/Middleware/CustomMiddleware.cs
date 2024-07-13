using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Do something with the incoming request
            Console.WriteLine("Handling request.");

            // Call the next middleware in the pipeline
            await _next(context);

            // Do something with the outgoing response
            Console.WriteLine("Handling response.");
        }
    }
}
