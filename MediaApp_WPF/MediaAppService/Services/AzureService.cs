using Azure.Storage.Blobs;
using MediaAppService.DataContract;
using MediaServices.Helper;
using MediaServices.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MediaServices.Services
{
    public class AzureService : IAzureService
    {
        private readonly string Azure_Storage_Conn_String = "";

        private readonly string containerName = "videos";

        private static BlobServiceClient blobServiceClient;

        private static BlobContainerClient containerClient;

        private readonly string DownloadFolderPath = @"C:\Users\Shiva Bulbul\Downloads\IntuitSample\";


        public AzureService()
        {
            if (blobServiceClient == null)
            {
                blobServiceClient = new BlobServiceClient(Azure_Storage_Conn_String);
                containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            }
        }

        public async void UploadFile(string filePathWithName)
        {
            string fileName = Path.GetFileName(filePathWithName);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            Debug.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

            // Upload data from the local file, overwrite the blob if it already exists

            var result = await blobClient.UploadAsync(filePathWithName, true);

            Debug.WriteLine("Upload completedd.");
        }

        public async Task DownloadFile()
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(Azure_Storage_Conn_String);
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

            if (!Directory.Exists(DownloadFolderPath))
            {
                Directory.CreateDirectory(DownloadFolderPath);
            }

            var blobs = blobContainerClient.GetBlobs();

            foreach (var blobItem in blobs)
            {
                string fileName = DownloadFolderPath + blobItem.Name;
                var blobClient = blobContainerClient.GetBlobClient(blobItem.Name);
                await blobClient.DownloadToAsync(fileName);
            }
        }

        public List<VideoDataContract> GetVideoList()
        {
            List<VideoDataContract> videoList = new List<VideoDataContract>();
            try
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(Azure_Storage_Conn_String);
                var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

                var blobs = blobContainerClient.GetBlobs().ToList();

                foreach (var blobItem in blobs)
                {
                    VideoDataContract vid = new()
                    {
                        VideoName = blobItem.Name,
                        VideoSize = blobItem.Properties.ContentLength ?? default,
                        ModifiedDate = blobItem.Properties.LastModified.HasValue ? blobItem.Properties.LastModified.Value.DateTime : default
                    };
                    videoList.Add(vid);
                }

                return videoList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return videoList;
            }
        }

        public async Task DownloadFile(string filename)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(Azure_Storage_Conn_String);
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
            var blobPages = blobContainerClient.GetBlobsAsync().AsPages();

            if (!Directory.Exists(DownloadFolderPath))
            {
                Directory.CreateDirectory(DownloadFolderPath);
            }

            var blobs = blobContainerClient.GetBlobs().ToList();
            var blobItem = blobs.Where(x => x.Name.ToLower() == filename.ToLower()).FirstOrDefault();

            if (blobItem != null)
            {
                string fileName = DownloadFolderPath + blobItem.Name;
                var blobClient = blobContainerClient.GetBlobClient(blobItem.Name);
                await blobClient.DownloadToAsync(fileName);
            }
            Debug.WriteLine("Success");

        }

    }
}
