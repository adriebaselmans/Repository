using System;

namespace MilFormat.Interfaces
{
    public interface IDomainObject
    {
        Guid InstanceGuid { get; set; }
    }
}