using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Android.Content.PM;

namespace PorpoiseMobileApp.Droid
{
 
    [Activity(Label= "@string/app_name",
        Theme = "@style/Porpoise.Splash", 
        MainLauncher = true, 
        Icon="@drawable/Icon", 
        NoHistory = true, 
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class Splash : MvxSplashScreenActivity
    {
        public Splash() : base(Resource.Layout.SplashScreen)
        {

        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
        }
    }
}