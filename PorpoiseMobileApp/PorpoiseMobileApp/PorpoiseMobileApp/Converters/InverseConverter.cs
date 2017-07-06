using System;
using MvvmCross.Platform.Converters;

namespace PorpoiseMobileApp.Converters
{
	public class InverseConverter : IMvxValueConverter
	{
		public InverseConverter ()
		{
		}

		#region IMvxValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !(bool)value;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !(bool)value;
		}

		#endregion
	}
}

