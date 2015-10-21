namespace Repository.Storage
{
    public interface IMetaStreamReader
    {
        T Read<T>() where T : class;
    }
}