using System;
using Repository.Interfaces;

namespace Repository.DomainObjects
{
    public struct Series : IDomainObject<Guid, Guid>
    {
        public Guid Key { get; set; }
        public Guid Id { get; set; }

        public Modality Modality { get; set; }
        public SeriesType Type { get; set; }
    }

    public enum SeriesType
    {
        XRayRun,
        Volume,
        ApplicationData,
        Snapshot,
        Movie
    }

    public enum Modality
    {
        XA,
        CT,
        MR
    }
}