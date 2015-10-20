using System;
using System.Collections.Generic;
using Repository.DomainObjects;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class StudyRepository : IRepository<Guid, Study>, IChildRelation<Series>, IParentRelation<Patient>
    {
        public IEnumerable<Series> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> GetChildren(Func<Series, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Patient GetParent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Study> All()
        {
            throw new NotImplementedException();
        }

        public Study Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Study> Query(Func<Study, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Study item)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid key, Study item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid key)
        {
            throw new NotImplementedException();
        }
    }
}