using System.ComponentModel.DataAnnotations.Schema;

namespace FIQ.Interview.Api.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<WorkItem> WorkItems { get; set; }
        public Project() { 
        }
    }
}
