using System;
using System.Collections.Generic;

namespace MilFormat.Interfaces
{
    public interface IRepository<TKey, TDomainObject>
    {
        IEnumerable<TDomainObject> All();
        TDomainObject Get(TKey key);
        IEnumerable<TDomainObject> Query(Func<TDomainObject, bool> predicate);
        TKey Add(TDomainObject item);
        void Update(TKey key, TDomainObject item);
        void Delete(TKey key);
    }
}