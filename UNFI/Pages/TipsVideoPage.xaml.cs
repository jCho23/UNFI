using System;
using System.Collections.Generic;
using UNFI.Models;
using Xamarin.Forms;

namespace UNFI.Pages
{
    public partial class TipsVideoPage : ContentPage
    {
        public TipsVideoPage()
        {
            InitializeComponent();
            tipsVideoListView.ItemsSource = new List<TipsVideoModel>{
                new TipsVideoModel {Description= "Selector Tips and Tricks to make you more money!", PictureSource = "scan.png"},
               

            };
        }
    }
}
