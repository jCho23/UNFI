using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UNFI.Pages.BasePage
{
    public partial class FeedAddPostModalPage : ContentPage
    {
        public FeedAddPostModalPage()
        {
            InitializeComponent();

            BindingContext = Application.Current;
        }

        async void OnCanceled_Clicked(object sender, System.EventArgs e)
        {
            var homeView = new ContentPage();

            await Navigation.PushModalAsync(new NavigationPage(new Pages.UNFITabbedPage()));
        }
    }
}
