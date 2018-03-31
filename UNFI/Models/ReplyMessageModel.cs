using System;
namespace UNFI.Models
{
    public class ReplyMessageModel
    {
        public string Id { get; set; }

        public string PostMessageId { get; set; }
        public UserProfileModel ReplyUser { get; set; }
        public string ReplyText { get; set; }
    }
}
