﻿using Plugin.MediaManager;
using UNFI.Constants;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace UNFI
{
    public partial class App : Application
    {
        private const string PostKey = "PostText";
        private const string ReplyKey = "ReplyText";

        public App()
        {
            InitializeComponent();

            CrossMediaManager.Current.RequestHeaders.Add(MediaConstants.EncryptedVideoHeaderKey, MediaConstants.EncryptedVideoHeaderToken);

            var navigationPage = new Xamarin.Forms.NavigationPage(new Pages.BasePage.UNFITabbedPage());
            navigationPage.On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPrefersLargeTitles(true);

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string PostText
        {
            get
            {
                if (Properties.ContainsKey(PostKey))
                    return Properties[PostKey].ToString();

                return "";
            }

            set
            {
                Properties[PostKey] = value;
            }
        }

        public string ReplyText
        {
            get
            {
                if (Properties.ContainsKey(ReplyKey))
                    return Properties[ReplyKey].ToString();

                return "";
            }

            set
            {
                Properties[ReplyKey] = value;
            }
        }
    }
}
