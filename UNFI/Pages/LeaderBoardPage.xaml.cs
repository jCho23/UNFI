using System;
using System.Collections.Generic;

using Xamarin.Forms;

using UNFI.Models;

namespace UNFI.Pages
{
    public partial class LeaderBoardPage : ContentPage
    {
        public LeaderBoardPage()
        {
            InitializeComponent();
            leaderBoardListView.ItemsSource = new List<LeaderBoardModel>{
                new LeaderBoardModel {Rank = "1", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "2", Points= "200", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "3", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "4", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "5", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "6", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "7", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "8", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "9", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "10", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "11", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "12", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "13", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "14", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "15", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "16", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "17", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "18", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "19", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"}
            };
        }
    }
}