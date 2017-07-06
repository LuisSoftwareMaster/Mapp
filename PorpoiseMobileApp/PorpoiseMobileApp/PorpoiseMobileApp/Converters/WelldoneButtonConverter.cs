using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
	public class WelldoneButtonConverter : IMvxValueConverter
	{



		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var hourLog = (Models.HourLog)value;

			return null;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
