using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Series : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}