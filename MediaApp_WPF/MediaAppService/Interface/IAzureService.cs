using MediaAppService.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Interface
{
    public interface IAzureService
    {
        List<VideoDataContract> GetVideoList();

        void UploadFile(string filePathWithName);

        Task DownloadFile(string filename);
    }
}
