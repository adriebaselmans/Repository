using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Repository.DomainObjects;
using Repository.Storage.StorageModels;

namespace Repository.Storage
{
    public struct Constants
    {
        public const string MetaFileName = "xrayrun.meta";
        public const string BulkFileName = "xrayrun.bulk";
    }

    public class XRayRunModelWriter : Disposable, IXRayRunModelWriter
    {
        public void Write(XrayRunModel xrayRunModel)
        {
            var storageModel = new XRayRunStorageModel
            {
                Height = xrayRunModel.Height,
                Width = xrayRunModel.Width,
                NumberOfImages = xrayRunModel.Images.Count,
                Images = new List<BulkReference>()
            };

            using (var fileStream = File.Create(Constants.BulkFileName))
            {
                using (var bulkWriter = new BulkStreamWriter(fileStream))
                {
                    foreach (var image in xrayRunModel.Images)
                    {
                        var bulkRef = bulkWriter.Write(image.Data);
                        storageModel.Images.Add(bulkRef);
                    }
                }
            }

            using (var fileStream = File.Create(Constants.MetaFileName))
            {
                var metaWriter = new MetaStreamWriter(fileStream);
                metaWriter.Write(storageModel);
            }
        }
    }

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