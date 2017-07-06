
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.Droid.Views;
using PorpoiseMobileApp.ViewModels;

namespace PorpoiseMobileApp.Droid
{
	[MenuItem(MenuItem.Intercom)]
	public class SupportView : MvvmFragment<SupportViewModel>
	{
		public SupportView() : base(Resource.Layout.SupportView)
		{
		}

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
           /* var contactButton = view.FindViewById<Button>(Resource.Id.contact_button);

            contactButton.Click += ComposeEmail;*/
        }

        private void ComposeEmail(object sender, EventArgs e)
        {
           /* var email = new Intent(Intent.ActionSend);
            email.PutExtra(Intent.ExtraEmail, new string[] { ViewModel.SupportEmailAddress });    
            email.PutExtra(Intent.ExtraSubject, PorpoiseMobileApp.Resource.SupportEmailSubject);
            email.PutExtra(Intent.ExtraText,  PorpoiseMobileApp.Resource.SupportEmailBody);
            email.SetType("message/rfc822");
            StartActivity(email);*/
        }
    }
}

