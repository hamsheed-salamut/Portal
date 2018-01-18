using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Data
{
    public class UserData
    {
    
        public List<UserDetails> GetAllUserDetails()
        {
            List<UserDetails> userDetails = new List<UserDetails>
            {
                new UserDetails
                {
                    Id = 1,
                    Username = "hsalamut",
                    Password = "123",
                    AppModel = new List<AppDetails>
                    {
                       new AppDetails
                       {
                           Id = 1,
                           Name = "Messenger",
                           UrlAndroid = "http://192.168.100.7/apk/Messenger.apk",
                           UrliOs = "This iOS URL"
                       }, 
                       new AppDetails
                       {
                           Id = 2,
                           Name = "Pinterest",
                           UrlAndroid = "http://192.168.100.7/apk/Pinterest.apk",
                           UrliOs = "This iOS URL"
                       },
                       new AppDetails
                       {
                           Id = 3,
                           Name = "Tumblr",
                           UrlAndroid = "http://192.168.100.7/apk/Tumblr.apk",
                           UrliOs = "This iOS URL"
                       },
                    }
                },
                new UserDetails
                {
                    Id = 2,
                    Username = "simul1",
                    Password = "123",
                    AppModel = new List<AppDetails>
                    {
                       new AppDetails
                       {
                           Id = 1,
                           Name = "Tumblr",
                           UrlAndroid = "http://192.168.100.7/apk/Tumblr.apk",
                           UrliOs = "This iOS URL"
                       },
                       new AppDetails
                       {
                           Id = 3,
                           Name = "Pinterest",
                           UrlAndroid = "http://192.168.100.7/apk/Pinterest.apk",
                           UrliOs = "This iOS URL"
                       }
                    }
                },
                new UserDetails
                {
                    Id = 1,
                    Username = "simul2",
                    Password = "123",
                    AppModel = new List<AppDetails>
                    {
                       new AppDetails
                       {
                           Id = 2,
                           Name = "Messenger",
                           UrlAndroid = "http://192.168.100.7/apk/Messenger.apk",
                           UrliOs = "This iOS URL"
                       },
                       new AppDetails
                       {
                           Id = 3,
                           Name = "Pinterest",
                           UrlAndroid = "http://192.168.100.7/apk/Pinterest.apk",
                           UrliOs = "This iOS URL"
                       },
                    }
                },
                new UserDetails
                {
                    Id = 1,
                    Username = "simul3",
                    Password = "123",
                    AppModel = new List<AppDetails>
                    {
                       new AppDetails
                       {
                           Id = 1,
                           Name = "Messenger",
                           UrlAndroid = "http://192.168.100.7/apk/Messenger.apk",
                           UrliOs = "This iOS URL"
                       },
                       new AppDetails
                       {
                           Id = 2,
                           Name = "Tumblr",
                           UrlAndroid = "http://192.168.100.7/apk/Tumblr.apk",
                           UrliOs = "This iOS URL"
                       },
                    }
                },
            };

            return userDetails;
        }

    }
}
