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
                    PostText = "Anyone want to help out at the Boys and Girls club this Saturday? If you want to come, meet me in the lobby at 11:30am!",
                    Replies ="Replies: 8",
                    Location= "Building 24",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="https://unfi.blob.core.windows.net/bbq/hand2.png"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    Replies ="Replies: 23",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    Replies ="Replies: 23",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    Replies ="Replies: 23",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    Replies ="Replies: 23",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
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
