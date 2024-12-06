namespace FIQ.Interview.Api.Models.Response
{
    public class ProjectResponse
    {
        public ProjectResponse()
        {
            this.WorkItems= new List<WorkItemResponse>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public IList<WorkItemResponse> WorkItems { get; set; }
    }
}
