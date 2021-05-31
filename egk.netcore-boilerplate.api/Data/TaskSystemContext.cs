using egk.netcore_boilerplate.api.Data.Entities.Contracts;
using egk.netcore_boilerplate.api.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data
{
    public class TaskSystemContext : DbContext, IDBContext
    {
        private IHttpContextAccessor httpContextAccessor;
        public TaskSystemContext()
        {

        }
        public TaskSystemContext(DbContextOptions<TaskSystemContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            // Get all the entities that inherit from AuditableEntity
            // and have a state of Added or Modified
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IAuditableEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified || e.State == EntityState.Deleted));

            // For each entity we will set the Audit properties
            foreach (var entityEntry in entries)
            {
                // If the entity state is Added let's set
                // the CreatedAt and CreatedBy properties
                if (entityEntry.State == EntityState.Added)
                {
                    ((IAuditableEntity)entityEntry.Entity).CreatedDate = DateTime.UtcNow;
                    ((IAuditableEntity)entityEntry.Entity).CreatedBy = this.httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "EgK";
                }
                else if (entityEntry.State == EntityState.Modified)
                {
                    // If the state is Modified then we don't want
                    // to modify the CreatedAt and CreatedBy properties
                    // so we set their state as IsModified to false
                    Entry((IAuditableEntity)entityEntry.Entity).Property(p => p.CreatedDate).IsModified = false;
                    Entry((IAuditableEntity)entityEntry.Entity).Property(p => p.CreatedBy).IsModified = false;
                }
                else if (entityEntry.State == EntityState.Deleted)
                {
                    ((IAuditableEntity)entityEntry.Entity).DeletedDate = DateTime.UtcNow;
                    ((IAuditableEntity)entityEntry.Entity).DeletedBy = this.httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "EgK";
                    entityEntry.State = EntityState.Modified;
                }

                // In any case we always want to set the properties
                // ModifiedAt and ModifiedBy
                ((IAuditableEntity)entityEntry.Entity).ModifiedDate = DateTime.UtcNow;
                ((IAuditableEntity)entityEntry.Entity).ModifiedBy = this.httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "EgK";
            }

            // After we set all the needed properties
            // we call the base implementation of SaveChangesAsync
            // to actually save our entities in the database
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
