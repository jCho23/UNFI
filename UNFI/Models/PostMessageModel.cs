﻿using System;
namespace UNFI.Models
{
    public class PostMessageModel
    {
        public string Id { get; set; }

        public UserProfileModel PostUser { get; set; }
        public string PostText { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfReplies { get; set; }
    }
}