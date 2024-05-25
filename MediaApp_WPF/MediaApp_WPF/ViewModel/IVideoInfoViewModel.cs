using MediaApp_WPF.Model;
using System.Collections.ObjectModel;

namespace MediaApp_WPF.ViewModel
{
    public interface IVideoInfoViewModel
    {
        ObservableCollection<VideoInfo> VideoModelList { get; set; }
    }
}