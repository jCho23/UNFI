using System;
using System.Collections.Generic;

using Xamarin.Forms;

using UNFI.Models;

namespace UNFI.Pages
{
    public partial class TipsVideoPage : ContentPage
    {
        public TipsVideoPage()
        {
            InitializeComponent();
            tipsVideoListView.ItemsSource = new List<TipsVideoModel>{
                new TipsVideoModel {Description= "Selector Tips and Tricks", PictureSource = "scan.png"},
                new TipsVideoModel {Description= "Product Guide Training", PictureSource = "store.png"},
                new TipsVideoModel {Description= "Scanner Best Practices", PictureSource = "scanner.png"},
                new TipsVideoModel {Description= "How to stay SAFE at work!", PictureSource = "safety.png"},
            };
        }
    }
}