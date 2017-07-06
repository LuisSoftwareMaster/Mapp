using System;
using Android.Widget;

namespace PorpoiseMobileApp.Droid
{
	public class GivenWelldoneObject
	{
		Button _button;

		Models.HourLog _hourLog;

		public Button Button { 
		
			get {

				return _button;

			}
			set {

				_button = value;
			
			}
		
		}

		public Models.HourLog HourLog { 
		
			get {

				return _hourLog;

			}
			set {

				_hourLog = value;
			
			}
		
		}

	}
}
