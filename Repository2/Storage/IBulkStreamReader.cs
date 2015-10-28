namespace MilFormat.Storage
{
    public interface IBulkStreamReader
    {
        byte[] Read(BulkReference bulkReference);
    }
}