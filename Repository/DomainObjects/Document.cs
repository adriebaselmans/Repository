using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Document : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}