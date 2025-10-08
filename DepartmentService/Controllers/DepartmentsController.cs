using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DepartmentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private static readonly List<Department> Departments = new List<Department>();

        [HttpGet]
        public IActionResult GetDepartments()
        {
            return Ok(Departments);
        }

        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            var department = Departments.Find(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            department.Id = Departments.Count + 1;
            Departments.Add(department);
            return CreatedAtAction(nameof(GetDepartment), new { id = department.Id }, department);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDepartment(int id, Department updatedDepartment)
        {
            var department = Departments.Find(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            department.Name = updatedDepartment.Name;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var department = Departments.Find(d => d.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            Departments.Remove(department);
            return NoContent();
        }
    }
}
