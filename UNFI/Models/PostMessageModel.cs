using System;
namespace UNFI.Models
{
    public class PostMessageModel
    {
        public string Id { get; set; }

        public UserProfileModel PostUser { get; set; }
        public string PostText { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfReplies { get; set; }
        public string Replies { get; set; }

        public string Location { get; set; }
        public string PictureTwoUrl { get; set; }
    }
}