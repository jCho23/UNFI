using System;
using System.Collections.Generic;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.Views
{
    public partial class EventsViewCell : ViewCell
    {
        public EventsViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as PostMessageModel;

            MyPostsMessageLabel.Text = model.PostText;
            UserProfilePicture.Source = model.PostUser.PictureUrl;
        }
    }
}
