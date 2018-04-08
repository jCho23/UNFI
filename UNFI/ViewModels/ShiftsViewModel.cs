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

                    Request= "The Rock wants to cover Jason's shift ",
                    Status= "Pending Manager's Approval",
                    PictureTwoUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.pn",
                    PostUser= new UserProfileModel
                       
                    {
                        Name = "The Rock",
                        PictureUrl = "theRock.jpb"
                    }
                },
                new PostMessageModel
                {
                    PostText = "Mon, April 9 2018 : Shift 1",
                    Request= "Thanks The Rock for covering Jason's shift!",
                    Status= "Manager Approved",
                    PictureTwoUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.pn",
                    PostUser= new UserProfileModel
                    {
                        Name = "The Rock",
                        PictureUrl = "theRock.jpg",
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

