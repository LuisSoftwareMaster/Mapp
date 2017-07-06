using System;
using System.Globalization;
using Android.Widget;
using MvvmCross.Platform.Converters;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.Droid.Converters
{
	public class WelldoneButoonConverter : IMvxValueConverter
	{
		Button button;

		public WelldoneButoonConverter(Button button) {

			this.button = button;
		
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = (HourLog)value;


			foreach (Welldones aux in hourLog.WellDones)
			{

				if (aux.UserId.Equals(AccountInfo.UserId.ToString()))
				{

					button.SetBackgroundResource(Resource.Drawable.wellDoneOrange);

					return button;

				}

			}


			button.SetBackgroundResource(Resource.Drawable.wellDoneGray);
			

			return button;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
