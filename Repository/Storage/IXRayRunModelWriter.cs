using Repository.DomainObjects;

namespace Repository.Storage
{
    public interface IXRayRunModelWriter
    {
        void Write(XrayRunModel runModel);
    }
}