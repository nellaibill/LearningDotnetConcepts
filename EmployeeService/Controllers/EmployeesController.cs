using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>();

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(Employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = Employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = Employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.Name = updatedEmployee.Name;
            employee.Position = updatedEmployee.Position;
            employee.DepartmentId = updatedEmployee.DepartmentId;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = Employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            Employees.Remove(employee);
            return NoContent();
        }
    }
}
