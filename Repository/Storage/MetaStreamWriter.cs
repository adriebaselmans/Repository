using System.IO;
using System.Text;

namespace Repository.Storage
{
    public class MetaStreamWriter : IMetaStreamWriter
    {
        private Stream _stream;

        public MetaStreamWriter(Stream stream)
        {
            _stream = stream;
        }
        
        public void Write<T>(T metaObject) where T : class
        {
            var jsonString = JsonSerializer.SerializeObject(metaObject);
            using (var streamWriter = new StreamWriter(_stream, Encoding.UTF8))
            {
                streamWriter.Write(jsonString);
            }

            _stream = null;
        }
    }
}