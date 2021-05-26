using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Models.Task>
    {
        public void Configure(EntityTypeBuilder<Models.Task> builder)
        {
            builder.Property(q=>q.Title).IsRequired(false);
            builder.Property(q=>q.Priority);
            ////builder.Property(q=>q.DueDate);
            //builder.Property(q=>q.BackLogId);
            //builder.Property(q => q.ProjectId);
            //builder.Property(q => q.StatusId);

            builder.HasOne(b => b.Project)
                .WithMany(q => q.Tasks)
                .HasForeignKey(q => q.ProjectId);

            builder.HasOne(b => b.Status)
                .WithOne(q => q.Task)
                .HasForeignKey<Models.Task>(q => q.StatusId);
        }
    }
}
