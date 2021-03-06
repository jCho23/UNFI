﻿using System;
using System.Collections.ObjectModel;

using UNFI.Models;

namespace UNFI.ViewModels
{
    public class MyPostsViewModel : BaseViewModel
    {
        string numberOfReplies;

        ObservableCollection<PostMessageModel> myPostsListViewItemSource;

        public MyPostsViewModel()
        {
            myPostsListViewItemSource = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel()
                {
                    PostText = "@here Can anyone give me a ride to work for 1st shift today? Beers on me after!",
                    Replies ="Replies: 8",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "Huge shoutout to @Kevin for helping me load up a truck like a true pro! ",
                    Replies ="Replies: 24",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "Who wants to go watch the Providence Bruins play this weekend? I have 2 free tickets!",
                    Replies ="Replies: 88",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "@Meela that BBQ you made last Friday was AWESOME!! Can't wait for the next one!",
                    Replies ="Replies: 28",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "Anyone want to grab some beers after second shift and watch the RedSox play tonight?",
                    Replies ="Replies: 32",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "@Mike thanks for setting up the training session today, I learned a lot!",
                    Replies ="Replies: 21",
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