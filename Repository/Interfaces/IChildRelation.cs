using System;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IChildRelation<out TChild>
    {
        IEnumerable<TChild> GetChildren();
        IEnumerable<TChild> GetChildren(Func<TChild, bool> predicate);
    }
}