namespace MilFormat.Storage
{
    public interface IBulkStreamWriter
    {
        BulkReference Write(byte[] bytes);
    }
}