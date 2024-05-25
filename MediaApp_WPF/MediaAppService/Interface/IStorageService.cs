using MediaServices.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Interface
{
    public interface IStorageService
    {
        bool EstablishConnection(StorageOption storageType);

        void UploadFile(string filePathWithName);
    }
}
