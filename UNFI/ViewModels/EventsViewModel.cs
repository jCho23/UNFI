using System;
using System.Collections.ObjectModel;
using UNFI.Models;

namespace UNFI.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        string numberOfReplies;

        ObservableCollection<PostMessageModel> myPostsListViewItemSource;


        public EventsViewModel()
        {
            myPostsListViewItemSource = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel()
                {
                    PostText = "BBQ this Friday after second shift!! Respond if you are interested!",
                    Replies ="Replies: 23",
                    Location = "Building 32",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/BBQ3.png"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "Anyone want to help out at the Boys and Girls club this Saturday?",
                    Replies ="Replies: 8",
                    Location= "Building 24",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/hand2.png"
                    }
                },

				new PostMessageModel()
				{
					PostText = "Tips and Tricks training with Jo next Wed! Learn to make more $!",
					Replies ="Replies: 34",
					Location= "Building 44",
					PostUser= new UserProfileModel
					{
						PictureUrl="https://unfi.blob.core.windows.net/bbq/Training.png"
					}
				},

                new PostMessageModel()
                {
                    PostText = "Wine & Cheese tonight @7pm ! Bring your friends & family!",
                    Replies ="Replies: 43",
                    Location= "Building 22",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/Wine.png"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "SOUP POTLUCK TOMORROW! Bring in Veggies & Meat to participate!",
                    Replies ="Replies: 23",
                    Location= "Building 22",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/soup.png"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "Selectors VS Managers softball game this Saturday! Meet @10am in the lobby of 45!",
                    Replies ="Replies: 23",
                    Location= "Building 45",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/baseball.png"
                    }
                }
            };
        }

        public string NumberOfReplies
        {
            get => numberOfReplies;
            set => SetProperty(ref numberOfReplies, value);
        }

        public ObservableCollection<PostMessageModel> MyPostsListViewItemSource
        {
            get => myPostsListViewItemSource;
            set => SetProperty(ref myPostsListViewItemSource, value);
        }

    }
}
