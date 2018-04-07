﻿using System;
using System.Linq;
using System.Collections.Generic;

using UIKit;
using Foundation;

using ImageCircle.Forms.Plugin.iOS;
using Plugin.MediaManager.Forms.iOS;

namespace UNFI.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            VideoViewRenderer.Init();

            global::Xamarin.Forms.Forms.Init();

            ImageCircleRenderer.Init();

            XFGloss.iOS.Library.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
