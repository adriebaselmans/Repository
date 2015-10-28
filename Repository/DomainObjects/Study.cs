using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Study : IDomainObject<Guid, Guid>
    {
        public Guid Key { get; set; }
        public Guid Id { get; set; }
    }
}