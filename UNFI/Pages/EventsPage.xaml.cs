using System;
using System.Collections.Generic;
using UNFI.ViewModels;
using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            var myPostsViewModel = new EventsViewModel();
            this.BindingContext = myPostsViewModel;

            InitializeComponent();

            Application.Current.Resources["BackgroundColor"] = Color.Black;

        }

        void Handle_Activated(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
