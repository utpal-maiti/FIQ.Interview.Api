using FIQ.Interview.Api.Models;
using FIQ.Interview.Api.Service;

using Microsoft.AspNetCore.Mvc;

namespace FIQ.Interview.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController:ControllerBase
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet(Name = "GetProjectById")]

        public IActionResult GetProjectById(int projectId)
        {
            try
            {
                if (projectId<1)
                {
                    return BadRequest("Invalid Project Id");
                }

                var result = this.projectService.GetProjectWithWorkItems(projectId);

          

                return Ok(result);


            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
