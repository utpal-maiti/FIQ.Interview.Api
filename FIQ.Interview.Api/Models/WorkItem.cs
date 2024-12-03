using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIQ.Interview.Api.Models
{
    public class WorkItem
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public WorkItem() { }
    }
}
