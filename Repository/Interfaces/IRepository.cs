using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Repository.DomainObjects;

namespace Repository.Interfaces
{
    public interface IRepository<TKey, in TId>
    {
        Patient GetPatientById(TId id);
        Patient GetPatientByKey(TKey key);
        IEnumerable<Patient> GetPatients();
        TKey AddPatient(Patient patient);
        void DeletePatient(Patient patient);
        void UpdatePatient(Patient patient);

        Study GetStudyById(TId id);
        Study GetStudyByKey(TKey key);
        IEnumerable<Study> GetStudies();
        TKey AddStudy(Study study);
        void DeleteStudy(Study study);
        void UpdateStudy(Study study);

        Series GetSeriesById(TId id);
        Series GetSeriesByKey(TKey key);
        IEnumerable<Series> GetSeries();
        TKey AddSeries(Series series);
        void DeleteSeries(Series series);
        void UpdateSeries(Series series);
    }

    public interface IVolumeReader
    {
        void ReadMeta();
        void ReadVolume();
    }

    public interface IXrayRunReader
    {
        void ReadMeta();
        void ReadRun();
    }

    public interface IVolumeReaderFactory
    {
        IVolumeReader CreateVolumeReader(Series series);
    }

    public interface IXrayRunReaderFactory
    {
        IXrayRunReader CreateXRayRunReader(Series series);
    }

    public class XRayVolumeReaderFactory : IVolumeReaderFactory
    {
        public IVolumeReader CreateVolumeReader(Series series)
        {
            throw new NotImplementedException();
        }
    }

    public class CtVolumeReaderFactory : IVolumeReaderFactory
    {
        public IVolumeReader CreateVolumeReader(Series series)
        {
            throw new NotImplementedException();
        }
    }
}

