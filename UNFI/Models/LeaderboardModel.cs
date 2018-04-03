using System;
using System.Diagnostics.Contracts;
namespace UNFI.Models
{
    public class LeaderboardModel
    {
        public string ID { get; set; }
        public string TeamName { get; set; }
        public string Points { get; set; }
        public string PictureUrl { get; set; }
    }
}