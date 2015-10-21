namespace Repository.Storage
{
    public interface IBulkStreamReader
    {
        byte[] Read(BulkReference bulkReference);
    }
}