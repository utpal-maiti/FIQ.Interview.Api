using FIQ.Interview.Api.Models;

namespace FIQ.Interview.Api.Service;

public interface IProjectService
{
    Task<Project?> GetProjectWithWorkItemsAsync(int projectId);
}
