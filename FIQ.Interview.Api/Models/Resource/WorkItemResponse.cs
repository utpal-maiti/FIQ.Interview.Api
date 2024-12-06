namespace FIQ.Interview.Api.Models.Response
{
    public class WorkItemResponse
    {
        public WorkItemResponse()
        {
        }
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;

        public int ProjectId { get; set; }
    }
}
