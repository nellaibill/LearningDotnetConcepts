using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Microservices
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var response = new
            {
                message = "An error occurred while processing your request.",
                details = exception.Message
            };

            context.Result = new JsonResult(response)
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };

            // Log the exception (example with console logging)
            Console.WriteLine($"Exception: {exception.Message}");
        }
        }
}
