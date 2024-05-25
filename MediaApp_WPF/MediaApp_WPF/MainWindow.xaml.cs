using GalaSoft.MvvmLight.Ioc;
using MediaApp_WPF.Model;
using MediaApp_WPF.ViewModel;
using MediaServices.Interface;
using MediaServices.Services;
using Microsoft.Win32;
using System.ComponentModel.Composition;
using System.Windows;


namespace MediaApp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ////[Import(typeof(IVideoInfoViewModel))]
        ////private IVideoInfoViewModel videoInfoViewModel;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = SimpleIoc.Default.GetInstance<IVideoInfoViewModel>();
        }

        private async void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            //await GetFileAsync(AzureService.GetAzureServiceInstance());
        }

        private async Task GetFileAsync(IAzureService azureService)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Video Files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                string filePath = fileDialog.FileName;
                azureService.UploadFile(filePath);
            }
        }

        private async void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            //await AzureService.GetAzureServiceInstance().DownloadFile("6060027-uhd_2160_3840_25fps.mp4");
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = ((FrameworkElement)sender).DataContext as VideoInfo;

            var value = data().Name;

            (this.DataContext as IVideoInfoViewModel)
        }
    }
}