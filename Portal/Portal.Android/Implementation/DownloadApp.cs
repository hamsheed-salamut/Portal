using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Portal.Interfaces;
using Xamarin.Forms;
using Portal.Droid.Implementation;
using System.Net;

[assembly : Dependency(typeof(DownloadApp))]
namespace Portal.Droid.Implementation
{
    public class DownloadApp : IDownloadApp
    {
        public void DownloadApplication(string uri, string fileName)
        {
            try
            {
                var webClient = new WebClient();
                var url = new Uri(uri);

                webClient.DownloadFileAsync(url, Android.OS.Environment.ExternalStorageDirectory + "/download/" + fileName +".apk");

                webClient.DownloadFileCompleted += (s, e) =>
                {
                    Intent promptInstall = new Intent(Intent.ActionView).SetDataAndType(Android.Net.Uri.FromFile(new Java.IO.File(Android.OS.Environment.ExternalStorageDirectory + "/download/" + fileName+".apk")), "application/vnd.android.package-archive");
                    Forms.Context.StartActivity(promptInstall);
                };

            }
            catch (Exception ex)
            {

            }
        }
    }
}