using System.Runtime.Serialization;

namespace MilFormat.Storage
{
    [DataContract]
    public struct BulkReference
    {
        public BulkReference(int byteOffset, int numBytes)
        {
            ByteOffset = byteOffset;
            NumBytes = numBytes;
        }

        [DataMember]
        public int ByteOffset { get; set; }

        [DataMember]
        public int NumBytes { get; set; }
    }
}