using System;
using MilFormat.Interfaces;

namespace MilFormat.DomainObjects
{
    public struct Patient : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }
}