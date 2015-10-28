using System;
using MilFormat.Interfaces;

namespace MilFormat.DomainObjects
{
    public struct Series : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}