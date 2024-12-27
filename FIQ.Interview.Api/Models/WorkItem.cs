using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIQ.Interview.Api.Models
{
    public class WorkItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; } // Foreign key
        public Project Project { get; set; }

        public WorkItem()
        {
           
        }
    }
}
