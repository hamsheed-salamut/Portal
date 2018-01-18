using Portal.Interfaces;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Portal.ViewModels
{
    public class PortalViewModel : ContentPage, INotifyPropertyChanged
    {

        private string _username;
        public ICommand ShowCommandParameter { get; private set; }
        private IDownloadApp _downloadApp;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string ContentPage { get; set; }

        public PortalViewModel(UserDetails user)
        {
            ShowCommandParameter = new Command<AppDetails>(Show);
        }

        public void Show(AppDetails param)
        {
            _downloadApp = DependencyService.Get<IDownloadApp>();

            bool success = _downloadApp.DownloadApplication(param.UrlAndroid, param.Name);

            if (success)
            {
                Application.Current.MainPage.DisplayAlert("Success", param.Name + " has been downloaded and will be installed shortly", "OK");
            }
          
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
