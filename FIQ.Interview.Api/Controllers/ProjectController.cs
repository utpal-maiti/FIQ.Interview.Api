using FIQ.Interview.Api.Models;
using FIQ.Interview.Api.Models.Response;
using FIQ.Interview.Api.Service;

using Mapster;

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
                //throw new Exception("sssssssssssssssss");
                if (projectId<1)
                {
                    return BadRequest("Invalid Project Id");
                }

                var result = this.projectService.GetProjectWithWorkItems(projectId);

               var responseDto= result.Adapt<ProjectResponse>();

                return Ok(responseDto);


            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
                throw;
            }
        }
    }
}
