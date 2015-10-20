using System;
using System.Collections.Generic;
using Repository.DomainObjects;
using Repository.Interfaces;

namespace Repository.Repositories
{
    internal class SeriesRepository : IRepository<Guid, Series>, IChildRelation<Document>, IParentRelation<Study>
    {
        public IEnumerable<Document> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> GetChildren(Func<Document, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Study GetParent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> All()
        {
            throw new NotImplementedException();
        }

        public Series Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> Query(Func<Series, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Series item)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid key, Series item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid key)
        {
            throw new NotImplementedException();
        }
    }
}