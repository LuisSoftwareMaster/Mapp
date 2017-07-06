
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
using PorpoiseMobileApp.Droid.Helpers;
using PorpoiseMobileApp.Droid.Views;

namespace PorpoiseMobileApp.Droid
{
	[MenuItem(MenuItem.Challenges)]
	public class Challenges : MvvmFragment<ViewModels.ChallengeLogHourViewModel>
	{
		public Challenges() : base(Resource.Layout.Challenges) { 

		}
					
	}


}

