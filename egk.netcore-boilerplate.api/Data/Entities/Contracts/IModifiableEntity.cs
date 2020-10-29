using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Entities.Contracts
{
    public interface IModifiableEntity
    {
        string Name { get; set; }
    }
}
