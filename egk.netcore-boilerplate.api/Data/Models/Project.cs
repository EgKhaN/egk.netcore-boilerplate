using egk.netcore_boilerplate.api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Models
{
    public class Project : BaseEntity<int>
    {
        public ICollection<Models.Task> Tasks { get; set; }
    }
}
