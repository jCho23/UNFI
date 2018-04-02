using System;

using Xamarin.Forms;

namespace UNFI.Views
{
    public class LeaderboardViewCell : ContentPage
    {
        public LeaderboardViewCell()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

