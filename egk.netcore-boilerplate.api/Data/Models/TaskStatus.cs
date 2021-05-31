using egk.netcore_boilerplate.api.Data.Entities;

namespace egk.netcore_boilerplate.api.Data.Models
{
    public class TaskStatus : AuditableEntity<int>
    {
        public Models.Task Task { get; set; }
    }
}
