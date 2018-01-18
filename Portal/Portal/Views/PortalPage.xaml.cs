using Portal.Models;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PortalPage : ContentPage
    {
        public PortalPage()
        {
            InitializeComponent();
        }

        public PortalPage(UserDetails user)
        {
            InitializeComponent();
            BindingContext = new PortalViewModel(user);

            StackLayout stack = new StackLayout();

            foreach (var t in user.AppModel)
            { 
                Button btn = new Button();
                btn.Text = t.Name;
                btn.SetBinding(Button.CommandProperty, new Binding("ShowCommandParameter"));
                //  btn.CommandParameter = t.UrlAndroid;
                btn.CommandParameter = t;

                stack.Children.Add(btn);
            }

            Content = stack;

        }
    }
}