﻿using Application_Green_Quake.Models;
using Foundation;
using UIKit;

namespace Application_Green_Quake.iOS
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

            Rg.Plugins.Popup.Popup.Init();
            global::Xamarin.Forms.Forms.Init();
            Firebase.Core.App.Configure();
            Xamarin.FormsGoogleMaps.Init(AppConstants.GoogleMapsApiKey); // initialize for Xamarin.Forms.GoogleMaps
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
