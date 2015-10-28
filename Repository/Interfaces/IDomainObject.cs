using System;

namespace Repository.Interfaces
{
    public interface IDomainObject<TKey, TId>
    {
        TKey Key { get; set; }
        TId Id { get; set; }
    }
}