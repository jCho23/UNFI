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
                new LeaderBoardModel {Rank = "1", Points= "230", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "2", Points= "205", TeamName = "Kobe", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "3", Points= "195", TeamName = "Lebron", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "4", Points= "180", TeamName = "Magic", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "5", Points= "155", TeamName = "Wilt", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "6", Points= "145", TeamName = "Bird", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "7", Points= "140", TeamName = "Duncan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "8", Points= "135", TeamName = "Shaq", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "9", Points= "120", TeamName = "Lillard", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "10", Points= "110", TeamName = "Paul", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "11", Points= "105", TeamName = "Westbrook", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "12", Points= "95", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "13", Points= "80", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "14", Points= "75", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "15", Points= "60", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "16", Points= "55", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "17", Points= "50", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "18", Points= "45", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"},
                new LeaderBoardModel {Rank = "19", Points= "40", TeamName = "Jordan", PictureUrl = "https://www.pixelstalk.net/wp-content/uploads/2015/12/Air-Jordan-Logo-wallpapers-620x465.jpg"}

            };
        }
    }
}
