namespace Repository.Storage
{
    public interface IBulkStreamWriter
    {
        BulkReference Write(byte[] bytes);
    }
}