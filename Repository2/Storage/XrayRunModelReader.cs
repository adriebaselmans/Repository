using System.Collections.Generic;
using System.IO;
using MilFormat.DomainObjects;
using MilFormat.Storage.StorageModels;

namespace MilFormat.Storage
{
    public class XrayRunModelReader : IXrayRunModelReader
    {
        public XrayRunModel Read()
        {
            var xrayRunModel = new XrayRunModel();
            using (var metaFileStream = File.OpenRead(Constants.MetaFileName))
            {
                var metaWriter = new MetaStreamReader(metaFileStream);
                var xrayRunStorageModel = metaWriter.Read<XRayRunStorageModel>();

                xrayRunModel.Width = xrayRunStorageModel.Width;
                xrayRunModel.Height = xrayRunStorageModel.Height;
                xrayRunModel.Images = new List<ImageModel>();

                using (var bulkFileStream = File.OpenRead(Constants.BulkFileName))
                {
                    var bulkReader = new BulkStreamReader(bulkFileStream);
                    foreach (var bulkReference in xrayRunStorageModel.Images)
                    {
                        var buffer = bulkReader.Read(bulkReference);
                        xrayRunModel.Images.Add(new ImageModel(buffer));
                    }
                }
            }

            return xrayRunModel;
        }
    }
}