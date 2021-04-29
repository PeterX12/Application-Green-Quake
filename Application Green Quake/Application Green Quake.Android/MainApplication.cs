/*! \mainpage The MainApplication Native Android Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the MainApplication Native Android Class. It had to be modified to make the APKs work
 *
 */
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