using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IDomainObject
    {
        Guid InstanceGuid { get; set; }
    }

    public struct Patient : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }

    public struct Study : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }

    public struct Series : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }

    public struct Document : IDomainObject
    {
        public Guid InstanceGuid { get; set; }
    }

    public interface IRepository<TKey, TDomainObject>
    {
        IEnumerable<TDomainObject> All();
        TDomainObject Get(TKey key);
        IEnumerable<TDomainObject> Query(Func<TDomainObject, bool> predicate);
        TKey Add(TDomainObject item);
        void Update(TKey key, TDomainObject item);
        void Delete(TKey key);
    }

    public interface IStudyRepository : IRepository<Guid, Patient>
    {   
    }

    public class StudyRepository : IStudyRepository
    {
        public IEnumerable<Patient> All()
        {
            throw new NotImplementedException();
        }

        public Patient Get(Guid key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> Query(Func<Patient, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Patient item)
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
    }

    public class Program
    {
        public void Main()
        {
            var studyRepository = new StudyRepository();

            var referencedStudyKey = Guid.NewGuid();
            studyRepository.Query(study => study.InstanceGuid == referencedStudyKey);
        }
    }
}
