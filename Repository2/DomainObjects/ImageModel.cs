namespace MilFormat.DomainObjects
{
    public class ImageModel
    {
        public ImageModel(byte[] buffer)
        {
            Data = buffer;
        }

        public byte[] Data { get; }
    }
}