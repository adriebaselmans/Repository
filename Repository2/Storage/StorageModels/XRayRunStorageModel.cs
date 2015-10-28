using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MilFormat.Storage.StorageModels
{
    [DataContract(Name = "XRayRun")]
    public class XRayRunStorageModel
    {
        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public int NumberOfImages { get; set; }

        [DataMember]
        public List<BulkReference> Images { get; set; }
    }
}