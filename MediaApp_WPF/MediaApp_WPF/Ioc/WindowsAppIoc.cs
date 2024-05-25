using GalaSoft.MvvmLight.Ioc;
using MediaApp_WPF.ViewModel;
using MediaServices.Interface;
using MediaServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp_WPF.Ioc
{
    public static class WindowsAppIoc
    {
        public static void InitializeIoc()
        {
            RegisterServices();
            RegisterViewModels();

        }


        private static void RegisterServices()
        {
            SimpleIoc.Default.Register<IAzureService, AzureService>();
            //SimpleIoc.Default.Register<I/*/*AzureService*/*/, AzureService>();
        }

        private static void RegisterViewModels()
        {
            SimpleIoc.Default.Register<IVideoInfoViewModel, VideoInfoViewModel>();

        }
    }

}
