using System;
using MilFormat.Interfaces;

namespace MilFormat.DomainObjects
{
    public struct Document : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}