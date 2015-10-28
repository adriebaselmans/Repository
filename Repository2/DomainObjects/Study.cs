using System;
using MilFormat.Interfaces;

namespace MilFormat.DomainObjects
{
    public struct Study : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}