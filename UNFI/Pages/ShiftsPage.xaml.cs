using System;
using System.Collections.Generic;

using Xamarin.Forms;

using UNFI.Models;
using UNFI.ViewModels;

namespace UNFI.Pages
{
    public partial class ShiftsPage : ContentPage
    {
        public ShiftsPage()
        {
            var shiftsPageViewModel = new ShiftsViewModel();
            this.BindingContext = shiftsPageViewModel;

            InitializeComponent();
        }
    }
}