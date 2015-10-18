using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Patient : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}