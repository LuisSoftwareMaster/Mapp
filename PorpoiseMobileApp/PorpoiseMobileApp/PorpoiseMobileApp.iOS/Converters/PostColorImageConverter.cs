using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
	public class PostColorImageConverter : IMvxValueConverter
	{
		

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = (Models.HourLog)value;

			if (hourLog.MediaType.Equals("none"))
			{
				

				return false;
			
			}

			return true;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
