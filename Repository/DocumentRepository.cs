using System;
using System.Collections.Generic;
using Repository.DomainObjects;
using Repository.Interfaces;

namespace Repository
{
    internal class DocumentRepository : IRepository<Guid, Document>, IParentRelation<Series>
    {
        public Series GetParent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> All()
        {
            throw new NotImplementedException();
        }

        public Document Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Document> Query(Func<Document, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Document item)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid key, Document item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid key)
        {
            throw new NotImplementedException();
        }
    }
}