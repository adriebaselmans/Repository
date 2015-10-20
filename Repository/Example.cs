using System;
using Repository.Repositories;

namespace Repository
{
    public class Program
    {
        public void Main()
        {
            var studyRepository = new StudyRepository();

            var referencedStudyKey = Guid.NewGuid();
            var studies = studyRepository.Query(patient => patient.InstanceGuid == referencedStudyKey);
        }
    }
}