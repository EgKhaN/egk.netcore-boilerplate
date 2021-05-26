using egk.netcore_boilerplate.api.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data
{
    public class TaskSystemContext : DbContext, IDBContext
    {
        public TaskSystemContext()
        {

        }
        public TaskSystemContext(DbContextOptions<TaskSystemContext> options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<Models.TaskStatus> TaskStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Task System" },
                new Project { Id = 2, Name = "Budget System" },
                new Project { Id = 3, Name = "Boilerplate" },
                new Project { Id = 4, Name = "Scheduler" },
                new Project { Id = 5, Name = "Human Resources" },
                new Project { Id = 6, Name = "Personal Asistant" }
            );

            modelBuilder.Entity<Models.TaskStatus>().HasData(
                new Models.TaskStatus { Id = 1, Name = "ToDo" },
                new Models.TaskStatus { Id = 2, Name = "In Progress" },
                new Models.TaskStatus { Id = 3, Name = "Review" },
                new Models.TaskStatus { Id = 4, Name = "QA" },
                new Models.TaskStatus { Id = 5, Name = "Deployed" }
            );
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
