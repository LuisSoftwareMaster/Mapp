
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
using PorpoiseMobileApp.ViewModels;
using PorpoiseMobileApp.Droid.Helpers;

namespace PorpoiseMobileApp.Droid.Views
{

	[MenuItem(MenuItem.Intercom)]
	public class IntercomView : MvvmFragment<IntercomViewModel>
	{
		public IntercomView() : base(Resource.Layout.IntercomView)
		{
		}

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);



			//IO.Intercom.Android.Sdk.Intercom.Initialize(new Android.App.Application(), "android_sdk-8faa3035b036f1cb82ed4258c152c0bc3d51cf55", "s7ehrxki");
			//IO.Intercom.Android.Sdk.Intercom.Client().RegisterUnidentifiedUser();
		}

		//public override void OnViewCreated(View view, Bundle savedInstanceState)
		//{
		//    base.OnViewCreated(view, savedInstanceState);

		//    var btnSend = view.FindViewById<Button>(Resource.Id.btn_send);

		//    Bindings.Bind(btnSend).To(vm => vm.IntercomCommand);

		//    Bindings.Apply();                        
		//}
	}
}