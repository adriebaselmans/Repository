using System.Collections.Generic;

namespace MilFormat.DomainObjects
{
    public class XrayRunModel
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public List<ImageModel> Images { get; set; }
    }
}