using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Collector.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyDtdF0zxGRimUItAvXe8MB4SIxhXuXGHIU");
            Rg.Plugins.Popup.Popup.Init();
            LoadApplication(new App());
            BuildStyles();
            return base.FinishedLaunching(app, options);
        }

        private void BuildStyles()
        {
            var xfResources = Xamarin.Forms.Application.Current.Resources;
            if (xfResources == null)
                return;

            var mainColor = "MainColor";
            var mainBarTextColor = "MainBarTextColor";

            if (!xfResources.ContainsKey(mainColor) || !xfResources.ContainsKey(mainBarTextColor))
                return;

            var xfMainColor = (Xamarin.Forms.Color)xfResources[mainColor];
            var xfMainBarTextColor = (Xamarin.Forms.Color)xfResources[mainBarTextColor];

            var uiMainColor = UIColor.FromRGB(
                (nfloat)xfMainColor.R,
                (nfloat)xfMainColor.G,
                (nfloat)xfMainColor.B
            );

            var uiMainBarTextColor = UIColor.FromRGB(
                (nfloat)xfMainBarTextColor.R,
                (nfloat)xfMainBarTextColor.G,
                (nfloat)xfMainBarTextColor.B
            );

            UINavigationBar.Appearance.BarTintColor = uiMainColor;
            UINavigationBar.Appearance.TintColor = uiMainBarTextColor;
            UINavigationBar.Appearance.SetTitleTextAttributes(
                new UITextAttributes() { TextColor = uiMainBarTextColor }
            );

        }
    }
}
