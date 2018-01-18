using Portal.Data;
using Portal.Interfaces;
using Portal.Models;
using Portal.Views;
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
    public class LoginViewModel : INotifyPropertyChanged
    {
        private IDownloadApp _downloadApp;

        private string _username;
        private string _password;

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

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; private set; }
        List<UserDetails> allUsers;
        public LoginViewModel()
        {
           
            _downloadApp = DependencyService.Get<IDownloadApp>();
            LoginCommand = new Command(CheckLogin);
        }


        public void CheckLogin()
        {
            UserData userData = new UserData();

            allUsers = new List<UserDetails>();

            allUsers = userData.GetAllUserDetails();

            if (allUsers.Any(x => x.Username.Equals(Username) && x.Password.Equals(Password)))
            {
                var user = allUsers.Where(x => x.Username.Equals(Username) && x.Password.Equals(Password)).First();
                Application.Current.MainPage.Navigation.PushAsync(new PortalPage(user));
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Invalid credentials", "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /*  public void Download()
          {
              _downloadApp.DownloadApplication("http://192.168.100.5/apk/Messenger.apk", "Messenger");
          } S*/

    }
}
