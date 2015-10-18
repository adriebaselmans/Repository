using System;

namespace Repository.Interfaces
{
    public interface IDomainObject
    {
        Guid InstanceGuid { get; set; }
    }
}