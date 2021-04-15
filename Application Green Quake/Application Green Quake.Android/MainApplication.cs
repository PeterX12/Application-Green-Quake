#if DEBUG
using System;
using Android.App;
using Android.Runtime;
using Application_Green_Quake.Models;
using Plugin.CurrentActivity;

[Application(Debuggable = true)]
#else
using Android.App;
using Android.Runtime;
using Application_Green_Quake.Models;
using Plugin.CurrentActivity;
using System;

[Application(Debuggable = false)]
#endif
[MetaData("com.google.android.maps.v2.API_KEY",
			  Value = AppConstants.googleMapsApiKey)]
public class MainApplication : Application
{
	public MainApplication(IntPtr handle, JniHandleOwnership transer)
	  : base(handle, transer)
	{
	}

	public override void OnCreate()
	{
		base.OnCreate();
		CrossCurrentActivity.Current.Init(this);
	}
}