﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.ViewModels
{
    public class FeedViewModel : BaseViewModel
    {
        string postUserProfileUrl, postUserPostText, postUserName, numberOfReplies;

        ICommand refreshCommand;

        public ICommand RefreshCommand
        {
            get { return refreshCommand ?? (refreshCommand = new Command(async () => await ExecuteRefreshCommand())); }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        List<PostMessageModel> originalMessages = new List<PostMessageModel>();
        ObservableCollection<PostMessageModel> feedListViewItemSource = new ObservableCollection<PostMessageModel>();

        public FeedViewModel()
        {
            //PostUserProfileUrl = postMessage.PostUser.PictureUrl;
            //PostUserName = postMessage.PostUser.Name;
            //PostUserPostText = postMessage.PostText;

            //if (postMessage.NumberOfReplies == 1)
            //    NumberOfReplies = $"{postMessage.NumberOfReplies} Reply";
            //else
            //NumberOfReplies = $"{postMessage.NumberOfReplies} Replies";



            ItemsCurrentlyDisplayedInList = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel
                {
                    PostText = "@here --Car won't start, can someone give me a ride to work for second shift?",
                    Replies = "Replies: 23",
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
                new PostMessageModel
                {
                    PostText = "@Jo thank you so much for bringing in your famous homemade cookies, they were delicious!",
                    Replies = "Replies: 16",
                    PostUser= new UserProfileModel
                    {
                        Name = "Kylie Jenner",
                        PictureUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png",
                    }
                },
                new PostMessageModel
                {
                    PostText = "PSA: Super icy roads today, be careful coming into work. Highly recommend snow tires.",
                    Replies = "Replies: 32",
                    PostUser= new UserProfileModel
                    {
                        Name = "Kevin Hart",
                        PictureUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                    }
                },
                new PostMessageModel
                {
                    PostText = "Second Shift Selectors rocked last night! We set a new record for loading the most trucks in a day!",
                    Replies = "Replies: 8",
                    PostUser= new UserProfileModel
                    {
                        Name = "Michael Jordan",
                        PictureUrl = "https://i.ytimg.com/vi/RnSgCv2X0ns/hqdefault.jpg",
                    }
                }
            };

            originalMessages = ItemsCurrentlyDisplayedInList.ToList();

        }

        async Task ExecuteRefreshCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            feedListViewItemSource.Clear();

            var ClearedList = feedListViewItemSource;
            var GetPosts = originalMessages;

            if (ClearedList.Count() == 0)
            {
                foreach (var item in GetPosts)
                    ItemsCurrentlyDisplayedInList.Add(item);

                IsBusy = false;
            }

            else
            {
            }
        }

        public async Task ExecuteSearch(string text)
        {
            var messagesToDisplay = originalMessages.Where(
                message => message.PostText.ToLower()
                    .Contains(text.ToLower()));

            if (messagesToDisplay.Count() == 0)
                ItemsCurrentlyDisplayedInList.Clear();
            else if (messagesToDisplay.Count() > 0)
            {
                var messagesToAdd = messagesToDisplay.Except(ItemsCurrentlyDisplayedInList).ToList();
                foreach (var message in messagesToAdd)
                    ItemsCurrentlyDisplayedInList.Add(message);

                var messagesToRemove = ItemsCurrentlyDisplayedInList.Except(messagesToDisplay).ToList();
                foreach (var message in messagesToRemove)
                    ItemsCurrentlyDisplayedInList.Remove(message);
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                var messagesToAdd = originalMessages.Except(ItemsCurrentlyDisplayedInList).ToList();
                foreach (var item in messagesToAdd)
                    ItemsCurrentlyDisplayedInList.Add(item);
            }
            else
            {
                //Change UI Label to show that no records are found


            }
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
            get => feedListViewItemSource;
            set => SetProperty(ref feedListViewItemSource, value);
        }
    }
}