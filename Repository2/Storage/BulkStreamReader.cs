using System.IO;
using System.Text;

namespace MilFormat.Storage
{
    public class BulkStreamReader : Disposable, IBulkStreamReader
    {
        private BinaryReader _binaryReader;

        public BulkStreamReader(Stream stream)
        {
            _binaryReader = new BinaryReader(stream, Encoding.UTF8);
        }

        public byte[] Read(BulkReference bulkReference)
        {
            _binaryReader.BaseStream.Seek(bulkReference.ByteOffset, SeekOrigin.Begin);
            return _binaryReader.ReadBytes(bulkReference.NumBytes);
        }

        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                _binaryReader.Dispose();
                _binaryReader = null;
            }

            base.Dispose(disposing);
        }
    }
}