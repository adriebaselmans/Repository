using MilFormat.DomainObjects;

namespace MilFormat.Storage
{
    public interface IXRayRunModelWriter
    {
        void Write(XrayRunModel runModel);
    }
}