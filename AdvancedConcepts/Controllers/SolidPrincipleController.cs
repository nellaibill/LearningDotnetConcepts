using AdvancedConcepts.SolidPrinciple;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedConcepts.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SolidPrincipleController : ControllerBase
    {
        [HttpGet("OpenClosedPrinciple")]
        public IActionResult OpenClosedPrinciple()
        {
            ContractEmployeeOCP employee = new ContractEmployeeOCP();
            employee.Name = "John Doe";
            employee.Id = 1;
            employee.Salary = 5000;

            double bonus = employee.CalculateBonus();

            return Ok($"Employee Name: {employee.Name}, Employee ID: {employee.Id}, Bonus: {bonus}");
        }
        [HttpGet("LiskovSubstitutionPrinciple")]
        //Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
        public IActionResult LiskovSubstitutionPrinciple()
        {
            EmployeeManager manager = new EmployeeManager();
            PermanentEmployeeLSP permanentEmployee = new PermanentEmployeeLSP();
            permanentEmployee.Name = "Jane Smith";
            permanentEmployee.Id = 2;

            ContractEmployeeLSP contractEmployee = new ContractEmployeeLSP();
            contractEmployee.Name = "John Doe";
            contractEmployee.Id = 1;

            manager.PrintMinimumSalary(permanentEmployee);
            manager.PrintMinimumSalary(contractEmployee);

            return Ok("Minimum salaries printed successfully.");
        }


    }
}
