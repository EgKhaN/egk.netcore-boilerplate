using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Entities.Contracts
{
    public interface IAuditableEntity : IEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        byte[] Version { get; set; }
    }
    public interface IAuditableEntity<T> : IAuditableEntity
    {
        new T Id { get; }
    }
}
