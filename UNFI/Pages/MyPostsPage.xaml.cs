using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class MyPostsPage : ContentPage
    {
        public MyPostsPage()
        {
            var myPostsViewModel = new MyPostsViewModel();
            this.BindingContext = myPostsViewModel;

            InitializeComponent();
        }
    }
}
