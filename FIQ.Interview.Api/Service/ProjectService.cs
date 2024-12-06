using FIQ.Interview.Api.Models;

using Microsoft.EntityFrameworkCore;

namespace FIQ.Interview.Api.Service;

public class ProjectService : IProjectService
{
    private readonly ProjectDbContext dbContext;

    public ProjectService(ProjectDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Project GetProjectWithWorkItems(int projectId)
    {
       var project= this.dbContext.Projects.
                    Include(x=>x.WorkItems).
                    FirstOrDefault(x=>x.Id == projectId);

        return project;
    }
}
