using FIQ.Interview.Api.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using System.Diagnostics.Metrics;

namespace FIQ.Interview.Api
{
    public class ProjectDbContext : DbContext
    {
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Project.db");
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableServiceProviderCaching();
            optionsBuilder.EnableThreadSafetyChecks();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(b =>
            {

                b.Property(x => x.Id).IsRequired();
                b.HasData(
            new Project { Id = 1, Name = "Project A" },
            new Project { Id = 2, Name = "Project B" }
        );

            });

            modelBuilder.Entity<WorkItem>(b =>
            {
                b.Property(x => x.Id).IsRequired();
                b.HasData(
            new WorkItem { Id = 1, Title = "Task 1", Description = "Description 1", ProjectId = 1 },
                new WorkItem { Id = 2, Title = "Task 2", Description = "Description 2", ProjectId = 1 },
                new WorkItem { Id = 3, Title = "Task 3", Description = "Description 3", ProjectId = 2 }
        );
            });

           
            base.OnModelCreating(modelBuilder);
        }
    }
}
