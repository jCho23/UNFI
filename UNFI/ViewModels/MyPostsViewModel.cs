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
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }
                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
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
