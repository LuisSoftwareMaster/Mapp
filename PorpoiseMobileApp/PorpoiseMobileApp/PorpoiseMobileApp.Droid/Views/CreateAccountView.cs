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
    class CreateAccountView : MvvmAppCompatActivity<CreateAccountViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            if (this.ActionBar != null)
            {
                this.ActionBar.Hide();
            }

            this.SetContentView(Resource.Layout.CreateAccount);

            var createAccountButton = this.FindViewById<Button>(Resource.Id.create_account_button);

            Bindings.Bind(createAccountButton).To(vm => vm.Registrate);

            Bindings.Apply();
        }
        }
}