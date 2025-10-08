using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjectService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private static readonly List<Project> Projects = new List<Project>();
        private readonly HttpClient _httpClient;

        public ProjectsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok(Projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            var project = Projects.Find(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(Project project)
        {
            // Check if the employee exists in the Employee Service
            var response = await _httpClient.GetAsync($"http://localhost:5000/api/employees/{project.EmployeeId}");
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest("Employee not found");
            }

            project.Id = Projects.Count + 1;
            Projects.Add(project);
            return CreatedAtAction(nameof(GetProject), new { id = project.Id }, project);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProject(int id, Project updatedProject)
        {
            var project = Projects.Find(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            project.Name = updatedProject.Name;
            project.EmployeeId = updatedProject.EmployeeId;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            var project = Projects.Find(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            Projects.Remove(project);
            return NoContent();
        }
    }
}
