using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using UNFI.Models;

namespace UNFI.ViewModels
{
    public class ShiftsViewModel: BaseViewModel
    {
        string postUserProfileUrl, postUserPostText, postUserName, numberOfReplies;

        List<PostMessageModel> originalMessages = new List<PostMessageModel>();
        ObservableCollection<PostMessageModel> shiftsListViewItemSource = new ObservableCollection<PostMessageModel>();

        public ShiftsViewModel()
        {

            ItemsCurrentlyDisplayedInList = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel
                {
                    PostText = "Mon, April 9 2018 : Shift 1",
                    Replies = "Replies: 23",
                    PictureTwoUrl = "theRock.jpg",
                    PostUser= new UserProfileModel
                    {
                        Name = "Sarah Jenner",
                        PictureUrl = "https://lion.blob.core.windows.net/pic1/pic1.jpeg"
                    }
                },
                new PostMessageModel
                {
                    PostText = "Potluck this Friday for lunch! I'm bringing home-cooked ribs, anyone else in? ",
                    Replies = "Replies: 24",
                    PostUser= new UserProfileModel
                    {
                        Name = "Suzanne Jenner",
                        PictureUrl = "https://lion.blob.core.windows.net/pic2/pic2.jpeg",
                    }
                },
                new PostMessageModel
                {
                    PostText = "Shoutout to @JasonDalomba who helped me put together a palette and load up the truck like a pro!",
                    Replies = "Replies: 18",
                    PostUser= new UserProfileModel
                    {
                        Name = "The Rock",
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },

               
            };

          

        }


      

        public string PostUserName
        {
            get => postUserName;
            set => SetProperty(ref postUserName, value);
        }

        public string PostUserPostText
        {
            get => postUserPostText;
            set => SetProperty(ref postUserPostText, value);
        }

        public string PostUserProfileUrl
        {
            get => postUserProfileUrl;
            set => SetProperty(ref postUserProfileUrl, value);
        }

        public string NumberOfReplies
        {
            get => numberOfReplies;
            set => SetProperty(ref numberOfReplies, value);
        }

        public ObservableCollection<PostMessageModel> ListViewItemSource { get; set; } = new ObservableCollection<PostMessageModel>();

        public ObservableCollection<PostMessageModel> ItemsCurrentlyDisplayedInList
        {
            get => shiftsListViewItemSource;
            set => SetProperty(ref shiftsListViewItemSource, value);
        }
    }
}

