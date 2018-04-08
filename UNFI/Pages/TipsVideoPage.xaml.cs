using System;
using System.Collections.Generic;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class TipsVideoPage : ContentPage
    {
        public TipsVideoPage()
        {
            InitializeComponent();
            tipsVideoListView.ItemsSource = new List<LeaderBoardModel>{
                new LeaderBoardModel {Rank = "1", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "2", Points= "200", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "3", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "4", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "5", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"}

            };
        }
    }
}
