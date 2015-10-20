using System;
using System.IO;
using System.Text;

namespace Repository.Storage
{
    public interface IBulkReference
    {
        /// <summary>
        /// The offset in bytes
        /// </summary>
        int Offset { get; }

        /// <summary>
        /// The size in bytes
        /// </summary>
        int Size { get; } 
    }

    public interface IBulkStreamReader
    {
        byte[] Read(IBulkReference bulkReference);
    }

    public interface IBulkStreamWriter
    {
        void Write(byte[] bytes, ref IBulkReference bulkReference);
    }

    public class BulkStreamReader : IBulkStreamReader, IDisposable
    {
        private BinaryReader _binaryReader;

        public BulkStreamReader(Stream stream)
        {
            _binaryReader = new BinaryReader(stream, Encoding.UTF8);
        }

        public byte[] Read(IBulkReference bulkReference)
        {
            _binaryReader.BaseStream.Seek(bulkReference.Offset, SeekOrigin.Begin);
            return _binaryReader.ReadBytes(bulkReference.Size);
        }

        public void Dispose()
        {
            _binaryReader.Dispose();
            _binaryReader = null;
        }
    }

    public class BulkStreamWriter : IBulkStreamWriter, IDisposable
    {
        private BinaryWriter _binaryWriter;
        private int _offset;

        public BulkStreamWriter(Stream stream)
        {
            _binaryWriter = new BinaryWriter(stream, Encoding.UTF8);
            _offset = 0;
        }

        public void Write(byte[] bytes, ref IBulkReference bulkReference)
        {
            var numBytes = bytes.Length;
            _binaryWriter.Write(bytes, 0, numBytes);
            bulkReference.Size = numBytes;
            bulkReference.Offset = _offset;

            _offset += bytes.Length;
        }
        
        public void Dispose()
        {
            _binaryWriter.Dispose();
            _binaryWriter = null;
        }

    }
}