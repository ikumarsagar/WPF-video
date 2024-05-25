using MediaServices.Helper;
using MediaServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServices.Services
{
    public class StorageService : IStorageService
    {
        public StorageService() { }

        public bool EstablishConnection(StorageOption storageType)
        {
            throw new NotImplementedException();
        }

        //public bool EstablishConnection(StorageOption storageType)
        //{
        //    switch (storageType)
        //    {
        //        case StorageOption.OneDrive:
        //            var obj = new OneDriveService().EstablishConnection();
        //            return true;
        //        case StorageOption.AzureStorage:
        //            return new AzureService().EstablishConnection();
        //        default:
        //            return false;

        //    }
        //}

        public void UploadFile(string filePathWithName)
        {
            throw new NotImplementedException();
        }
    }
}
