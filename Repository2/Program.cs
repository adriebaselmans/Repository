using System.Collections.Generic;
using MilFormat.DomainObjects;
using MilFormat.Storage;

namespace MilFormat
{
    public static class Program
    {
        public static void Main()
        {
            var xrayRunModel = new XrayRunModel
            {
                Height = 4,
                Width = 4,
                Images = new List<ImageModel>
                {
                    new ImageModel(new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}),
                    new ImageModel(new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}),
                    new ImageModel(new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}),
                    new ImageModel(new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})
                }
            };

            var xrayRunWriter = new XRayRunModelWriter();
            xrayRunWriter.Write(xrayRunModel);
            xrayRunWriter.Dispose();

            var xrayRunReader = new XrayRunModelReader();
            var xrayRunModel2 = xrayRunReader.Read();
        }
    }
}