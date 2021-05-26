using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Entities.Contracts
{
    public interface IEntity : IModifiableEntity
    {
        object Id { get; }
    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get;  }
    }
}
