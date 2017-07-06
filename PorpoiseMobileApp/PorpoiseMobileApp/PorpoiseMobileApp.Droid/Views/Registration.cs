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
using PorpoiseMobileApp.Droid.MvvmCross;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.Droid.Views
{
    [Activity(Theme = "@style/AppTheme")]
    class Registration : MvvmAppCompatActivity<RegistrationViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            if (this.ActionBar != null)
            {
                this.ActionBar.Hide();
            }

            this.SetContentView(Resource.Layout.Registration);
        }
    }
}