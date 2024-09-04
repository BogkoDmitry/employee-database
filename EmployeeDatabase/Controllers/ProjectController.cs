using EmployeeDatabase.BLL.Interfaces;
using EmployeeDatabase.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Project>>> GetUsers()
        {
            var result = await _projectService.GetProjectsAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(Project project)
        {
            var result = await _projectService.CreateProjectAsync(project);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<Project>> Update(int id, Project project)
        {
            var result = await _projectService.UpdateProjectAsync(id, project);

            return result;
        }
    }
}
