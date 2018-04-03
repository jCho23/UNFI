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
                new LeaderBoardModel {TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/jordan-logo-wallpaper-hd/#/lightbox&slide=1"}
            };
        }
    }
}
