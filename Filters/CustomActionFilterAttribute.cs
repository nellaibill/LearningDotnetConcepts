using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters
{
    public class CustomActionFilterAttribute : Attribute, IActionFilter
    {
        private readonly string _name;

        public CustomActionFilterAttribute(string name)
        {
            this._name = name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"On Action executed - {this._name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"On Action executing - {this._name}");
        }
    }
}
