using System;
using System.Collections.Generic;
using UNFI.Models;
using UNFI.ViewModels;
using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class FeedDetailsPage : ContentPage
    {
        public FeedDetailsPage(PostMessageModel postMessage)
        {
            var feedDetailsViewModel = new FeedDetailsViewModel(postMessage);
            this.BindingContext = feedDetailsViewModel;

            InitializeComponent();
        }

        void OnReplyTextLimit(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 23)
            {
                replyPostInput.Text = replyPostInput.Text.Remove(23);

            }
        }


    }
}