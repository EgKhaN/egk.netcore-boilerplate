using egk.netcore_boilerplate.api.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Models
{
    public class Task : AuditableEntity<int>
    {
        public string Title { get; set; }
        private int? priority { get; set; }
        public int Priority
        {
            get { return priority ?? 1; }
            set { priority = value; }
        }

        private DateTime? dueDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DueDate
        {
            get { return dueDate ?? DateTime.UtcNow; }
            set { dueDate = value; }
        }
        private int? backlogId { get; set; }
        public int BackLogId
        {
            get { return backlogId ?? 1; }
            set { backlogId = value; }
        }
        private int? projectId { get; set; }
        public int ProjectId
        {
            get { return projectId ?? 1; }
            set { projectId = value; }
        }
        public Project Project { get; set; }
        private int? statusId { get; set; }
        public int StatusId
        {
            get { return statusId ?? 1; }
            set { statusId = value; }
        }
        public TaskStatus Status { get; set; }
        public bool? IsDone { get; set; }
    }
}
