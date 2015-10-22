using Repository.DomainObjects;

namespace Repository.Storage
{
    public interface IXrayRunModelReader
    {
        XrayRunModel Read();
    }
}