using FIQ.Interview.Api.Models;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics.Metrics;

namespace FIQ.Interview.Api
{
    public class ProjectDbContext : DbContext
    {
        protected ProjectDbContext()
        {
            this.Database.EnsureCreated();
         
        }

        public virtual DbSet<Project> Projects { get; set; } 
        public virtual DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Project.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(b =>
            {
              
                b.Property(x => x.Id).IsRequired();
                b.HasData(
                    new Project { Id = 1, Name = "Project1" },
                    new Project { Id = 2, Name = "Project2" },
                    new Project { Id = 3, Name = "Project3" },
                    new Project { Id = 4, Name = "Project4" }
                    );
            });

            modelBuilder.Entity<WorkItem>(b =>
            {
                b.Property(x => x.Id).IsRequired();
                b.HasData(
                    new WorkItem { Id = 1, Description = "Description1", ProjectId = 1 },
                    new WorkItem { Id = 2, Description = "Description2", ProjectId = 1 },
                    new WorkItem { Id = 3, Description = "Description1", ProjectId = 2 },
                    new WorkItem { Id = 4, Description = "Description1", ProjectId = 2 },
                    new WorkItem { Id = 5, Description = "Description1", ProjectId = 3 }
                );
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
