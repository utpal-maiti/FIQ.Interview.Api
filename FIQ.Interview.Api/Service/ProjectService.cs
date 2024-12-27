using FIQ.Interview.Api.Models;

using Microsoft.EntityFrameworkCore;

namespace FIQ.Interview.Api.Service;

public class ProjectService : IProjectService
{
    private readonly ProjectDbContext _context;

    public ProjectService(ProjectDbContext dbContext)
    {
        this._context = dbContext;
        this._context.Database.EnsureCreated();
    }

    public async Task<Project?> GetProjectWithWorkItemsAsync(int projectId)
    {
        var project= await _context.Projects
            .Include(p => p.WorkItems)
            .FirstOrDefaultAsync(p => p.Id == projectId);
        return await Task.FromResult(project);
    }
}
