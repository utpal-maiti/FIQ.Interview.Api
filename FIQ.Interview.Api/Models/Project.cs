using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIQ.Interview.Api.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<WorkItem> WorkItems { get; set; } // One-to-Many relationship
        public Project() { 
            
        }
    }
}
