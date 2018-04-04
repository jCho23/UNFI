using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UNFI.Pages.BasePage
{
    public partial class UNFITabbedPage : TabbedPage
    {
        public UNFITabbedPage()
        {
            InitializeComponent();

            switch (Xamarin.Forms.Device.RuntimePlatform)
            {
                case Xamarin.Forms.Device.iOS:
                    break;
                case Xamarin.Forms.Device.Android:
                    break;
            }

            CurrentPageChanged += Handle_CurrentPageChanged;
        }

        void Handle_CurrentPageChanged(object sender, EventArgs e)
        {
            Title = CurrentPage?.Title ?? "UNFI";
        }

    }
}
