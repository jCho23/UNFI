using System;
using System.Collections.Generic;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.Views
{
    public partial class MyPostsViewCell : ViewCell
    {
        public MyPostsViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as PostMessageModel;

            PostMessageLabel.Text = model.PostText;
            UserProfilePicture.Source = model.PostUser.PictureUrl;
        }
    }
}
