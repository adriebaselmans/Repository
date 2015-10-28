using System.IO;
using System.Text;

namespace MilFormat.Storage
{
    public class MetaStreamReader : IMetaStreamReader
    {
        private Stream _stream;

        public MetaStreamReader(Stream stream)
        {
            _stream = stream;
        }

        public T Read<T>() where T : class
        {
            T metaObject = null;
            using (var streamReader = new StreamReader(_stream, Encoding.UTF8))
            {
                var jsonStr = streamReader.ReadToEnd();
                metaObject = JsonSerializer.DeserializeObject<T>(jsonStr);
            }

            _stream = null;
            return metaObject;
        }
    }
}