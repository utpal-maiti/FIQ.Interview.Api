using FIQ.Interview.Api.Models;
using FIQ.Interview.Api.Models.Response;
using FIQ.Interview.Api.Service;

using Mapster;

using Microsoft.AspNetCore.Mvc;

namespace FIQ.Interview.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController:ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            this._projectService = projectService;
        }

        [HttpGet("{projectId}", Name = "GetProjectById")]

        public async Task<IActionResult> GetProjectByIdAsync([FromRoute]int projectId)
        {
            try
            {
                //throw new Exception("User Exception");
                if (projectId<1)
                {
                    return BadRequest("Invalid Project Id");
                }

                var project = await this._projectService.GetProjectWithWorkItemsAsync(projectId);
                if (project == null)
                {
                    return NotFound();
                }
                var result = project.Adapt<ProjectResponse>();

                return Ok(result);

            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
                throw;
            }
        }
    }
}
