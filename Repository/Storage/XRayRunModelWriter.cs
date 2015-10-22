using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Repository.DomainObjects;
using Repository.Storage.StorageModels;

namespace Repository.Storage
{
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
}