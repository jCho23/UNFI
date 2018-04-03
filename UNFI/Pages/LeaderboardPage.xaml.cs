using System;
using System.Collections.Generic;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class LeaderBoardPage : ContentPage
    {
        public LeaderBoardPage()
        {
            InitializeComponent();

            leaderBoardListView.ItemsSource = new List<LeaderBoardModel>{
                new LeaderBoardModel {TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"}
            };
        }
    }
}
