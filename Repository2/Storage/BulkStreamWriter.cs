using System.IO;
using System.Text;

namespace MilFormat.Storage
{
    public class BulkStreamWriter : Disposable, IBulkStreamWriter
    {
        private BinaryWriter _binaryWriter;
        private int _offset;

        public BulkStreamWriter(Stream stream)
        {
            _binaryWriter = new BinaryWriter(stream, Encoding.UTF8);
            _offset = 0;
        }

        public BulkReference Write(byte[] bytes)
        {
            var numBytes = bytes.Length;
            _binaryWriter.Write(bytes, 0, numBytes);

            var bulkRef = new BulkReference(_offset, numBytes);
            _offset += bytes.Length;

            return bulkRef;
        }

        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                _binaryWriter.Dispose();
                _binaryWriter = null;
            }

            base.Dispose(disposing);
        }
    }
}