using System;
using System.Collections.Generic;
using Repository.DomainObjects;
using Repository.Interfaces;

namespace Repository.Repositories
{
    internal class PatientRepository : IRepository<Guid, Patient>, IChildRelation<Study>
    {
        public IEnumerable<Study> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Study> GetChildren(Func<Study, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Patient item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> Query(Func<Patient, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid key, Patient item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> All()
        {
            throw new NotImplementedException();
        }

        public Patient Get(Guid key)
        {
            throw new NotImplementedException();
        }
    }
}