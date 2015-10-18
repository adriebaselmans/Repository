using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Study : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}