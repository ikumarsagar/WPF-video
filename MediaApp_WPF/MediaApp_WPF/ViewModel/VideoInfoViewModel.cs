using MediaApp_WPF.Model;
using MediaAppService.DataContract;
using MediaServices.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaApp_WPF.ViewModel
{
    [Export(typeof(IVideoInfoViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class VideoInfoViewModel : INotifyPropertyChanged, IVideoInfoViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<VideoInfo> _videoModelList;
        public ObservableCollection<VideoInfo> VideoModelList
        {
            get
            {
                return _videoModelList;
            }
            set
            {
                _videoModelList = value;
                OnPropertyChanged();
            }
        }

        [ImportingConstructor]
        public VideoInfoViewModel(IAzureService azureService)
        {
            var vidList = azureService.GetVideoList();
            VideoModelList = new ObservableCollection<VideoInfo>();
            foreach (VideoDataContract vid in vidList)
            {
                VideoModelList.Add(new VideoInfo
                {
                    ModifiedDate = vid.ModifiedDate,
                    Name = vid.VideoName,
                    Size = vid.VideoSize
                });
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
